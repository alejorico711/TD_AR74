# Reglas del proyecto TD_AR74

- NUNCA instalar paquetes NuGet, bajo ninguna circunstancia.
- NUNCA modificar un archivo .cs que no sea *.Designer.cs. Toda la lógica de negocio vive en 
  los .cs "de código detrás" y no se toca sin pedido explícito.
- NUNCA renombrar controles (Name), agregar/quitar controles, ni tocar eventos ya cableados.
- NUNCA agregar imágenes embebidas en archivos .resx mediante la propiedad Image del Designer. 
  Si hace falta una imagen, copiarla a /Imagenes y cargarla por código con Image.FromFile().
- NUNCA tocar Stored Procedures, ni archivos de DAL, BLL, Mapper o BE sin pedido explícito.
- Al hacer cambios visuales en varios formularios, trabajar de a 2-3 por vez y confirmar que 
  el proyecto compila antes de continuar con los siguientes.