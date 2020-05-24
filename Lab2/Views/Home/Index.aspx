<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <h1>Bienvenido a mi pagina de Videos</h1>
    <h2>Opciones</h2>
    <br />
    <a href="/Video/Agregar">Registro de videos</a>
    <br />
    <a href="/Video/Eliminar">Eliminar videos</a>
    <br />
    <a href="/Video/Modificar">Actualizar videos</a>
    <br />
    <a href="/Video/Mostrar">Mostrar videos</a>

</body>
</html>
