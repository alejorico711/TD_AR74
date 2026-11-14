; ============================================================
; Instalador RoomIn (TD_AR74)
; ============================================================

#define MyAppName "RoomIn"
#define MyAppVersion "1.0"
#define MyAppExeName "ProyectoIS_64PR.exe"

; --- AJUSTAR ESTAS RUTAS A TU PC ---
#define MyRepo "C:\Users\Alejo\source\repos\TD_AR74"
#define MySourceDir MyRepo + "\ProyectoIS_64PR\bin\Release"
#define MySqlScript MyRepo + "\BD_64PR.sql"
#define MyImagenes MyRepo + "\ProyectoIS_64PR\Imagenes"
#define MyManual MyRepo + "\ProyectoIS_64PR\Ayuda\Manual_Ayuda_RoomIn.pdf"

[Setup]
; AppId fijo: es lo que le permite a Inno reconocer una instalación previa
; y reinstalar encima. NO cambiarlo entre versiones del instalador.
AppId={{9E2AE4BB-C519-4286-836F-F296071C776E}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
PrivilegesRequired=admin
ArchitecturesInstallIn64BitMode=x64compatible
Compression=lzma
SolidCompression=yes
; Si RoomIn está abierto, Inno ofrece cerrarlo antes de reemplazar archivos
CloseApplications=yes
RestartApplications=no
SetupIconFile={#MyImagenes}\Solo-logo.ico
UninstallDisplayIcon={app}\{#MyAppExeName}
OutputDir=C:\Users\Alejo\Desktop\Instalador
OutputBaseFilename=Instalador_RoomIn

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Files]
; Programa, DLLs, .exe.config y carpeta idiomas (sin .pdb y sin Imagenes, que se copian aparte)
Source: "{#MySourceDir}\*"; DestDir: "{app}"; Excludes: "*.pdb,Imagenes\*"; Flags: ignoreversion recursesubdirs createallsubdirs

; Imagenes: se toman de la carpeta del proyecto porque Visual Studio no copia todas a bin\Release
Source: "{#MyImagenes}\*"; DestDir: "{app}\Imagenes"; Flags: ignoreversion recursesubdirs createallsubdirs

; Manual de ayuda (PdfAyuda lo busca en {app}\Ayuda)
Source: "{#MyManual}"; DestDir: "{app}\Ayuda"; Flags: ignoreversion

; Script de la base de datos
Source: "{#MySqlScript}"; DestDir: "{app}\Database"; Flags: ignoreversion

[Dirs]
; GestorIdioma escribe en los JSON de esta carpeta (agrega "FALTA TRADUCCION"):
; en Archivos de programa los usuarios comunes no pueden escribir, se les da permiso
Name: "{app}\idiomas"; Permissions: users-modify

; Carpeta de backups; nunca se borra al desinstalar
Name: "C:\Backups_64PR"; Permissions: users-modify; Flags: uninsneveruninstall

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "Ejecutar {#MyAppName}"; Flags: postinstall nowait skipifsilent unchecked

[Code]
const
  // Misma GUID que AppId (con llaves simples)
  CLAVE_DESINSTALAR = 'Software\Microsoft\Windows\CurrentVersion\Uninstall\{9E2AE4BB-C519-4286-836F-F296071C776E}_is1';

var
  InstanciaPage: TInputQueryWizardPage;

function YaInstalado(): Boolean;
begin
  Result := RegKeyExists(HKLM64, CLAVE_DESINSTALAR) or RegKeyExists(HKLM32, CLAVE_DESINSTALAR);
end;

function InitializeSetup(): Boolean;
begin
  Result := True;
  if YaInstalado() then
  begin
    Result := SuppressibleMsgBox(
      'RoomIn ya está instalado en este equipo.' + #13#10 +
      'Se va a reinstalar: se reemplazarán los archivos del programa y se conservarán los datos de la base de datos.' + #13#10#13#10 +
      '¿Querés continuar?',
      mbConfirmation, MB_YESNO, IDYES) = IDYES;
  end;
end;

function DetectarInstanciaSQL(): String;
var
  Nombres: TArrayOfString;
  i: Integer;
  Clave: String;
begin
  Result := '.\SQLEXPRESS'; // valor por defecto si no detecta nada
  Clave := 'SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL';

  if not RegGetValueNames(HKLM64, Clave, Nombres) then
    RegGetValueNames(HKLM32, Clave, Nombres);

  for i := 0 to GetArrayLength(Nombres) - 1 do
  begin
    if Nombres[i] = 'MSSQLSERVER' then
      Result := '.'                  // instancia por defecto
    else
      Result := '.\' + Nombres[i];   // instancia con nombre
  end;
end;

procedure InitializeWizard();
begin
  InstanciaPage := CreateInputQueryPage(wpReady,
    'Configuración de Base de Datos',
    'Confirmá el nombre de la instancia de SQL Server',
    'Se detectó la siguiente instancia. Si no es correcta, corregila (podés verificarla en services.msc, mirando el nombre entre paréntesis del servicio "SQL Server"):');
  InstanciaPage.Add('Instancia de SQL Server:', False);
  InstanciaPage.Values[0] := DetectarInstanciaSQL();
end;

procedure MensajeCrearBaseManual();
begin
  MsgBox('No se pudo crear la base de datos automáticamente.' + #13#10 +
         'Abrí SQL Server Management Studio, cargá el archivo:' + #13#10 +
         ExpandConstant('{app}\Database\BD_64PR.sql') + #13#10 +
         'y ejecutalo manualmente antes de iniciar la aplicación.',
         mbInformation, MB_OK);
end;

procedure ConfigurarConexionYBase();
var
  RutaConfig, Instancia, Script: String;
  Contenido: AnsiString;
  ContenidoStr: String;
  ResultCode: Integer;
begin
  Instancia := InstanciaPage.Values[0];
  RutaConfig := ExpandConstant('{app}\ProyectoIS_64PR.exe.config');
  Script := ExpandConstant('{app}\Database\BD_64PR.sql');

  // 1) Reemplazar el placeholder de la instancia en el .exe.config
  if LoadStringFromFile(RutaConfig, Contenido) then
  begin
    ContenidoStr := String(Contenido);
    StringChangeEx(ContenidoStr, '#SQLINSTANCE#', Instancia, True);
    Contenido := AnsiString(ContenidoStr);
    SaveStringToFile(RutaConfig, Contenido, False);
  end;

  // 2) Ver si la base ya existe. sqlcmd devuelve como código de salida:
  //    2 = no existe, 3 = existe, cualquier otro valor = error (ej. no conecta)
  WizardForm.StatusLabel.Caption := 'Verificando base de datos...';
  if not Exec('sqlcmd.exe',
              '-S ' + Instancia + ' -Q "EXIT(SELECT CASE WHEN DB_ID(''BD_64PR'') IS NULL THEN 2 ELSE 3 END)"',
              '', SW_HIDE, ewWaitUntilTerminated, ResultCode) then
  begin
    // sqlcmd no está instalado en esta PC
    MensajeCrearBaseManual();
    Exit;
  end;

  if ResultCode = 3 then
    Exit; // La base ya existe (reinstalación): se conservan los datos, no se toca nada

  if ResultCode <> 2 then
  begin
    MsgBox('No se pudo conectar a la instancia "' + Instancia + '" para verificar la base de datos.' + #13#10 +
           'Revisá el nombre en services.msc y, si hace falta, corregilo en el archivo:' + #13#10 +
           RutaConfig + #13#10 +
           'Después creá la base manualmente ejecutando ' + Script + ' en SSMS.',
           mbInformation, MB_OK);
    Exit;
  end;

  // 3) La base no existe: crearla con el script
  WizardForm.StatusLabel.Caption := 'Creando base de datos...';
  if (not Exec('sqlcmd.exe', '-S ' + Instancia + ' -b -i "' + Script + '"',
               '', SW_HIDE, ewWaitUntilTerminated, ResultCode)) or (ResultCode <> 0) then
  begin
    // Si quedó una base a medias, se borra para que el paso manual arranque limpio
    Exec('sqlcmd.exe',
         '-S ' + Instancia + ' -Q "IF DB_ID(''BD_64PR'') IS NOT NULL BEGIN ALTER DATABASE BD_64PR SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE BD_64PR; END"',
         '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
    MensajeCrearBaseManual();
  end;
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then
    ConfigurarConexionYBase();
end;
