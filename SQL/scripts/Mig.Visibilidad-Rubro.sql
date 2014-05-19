--------------------------- INICIO VISIBILIDAD
use GD1C2014
go
insert into TG.Visibilidad
SELECT DISTINCT Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Precio, Publicacion_Visibilidad_Porcentaje
from gd_esquema.Maestra
where Publicacion_Visibilidad_Cod is not null
order by Publicacion_Visibilidad_Cod

--------------------------- FIN VISIBILIDAD -- INICIO RUBRO

insert into TG.Rubro(Nombre)
SELECT DISTINCT Publicacion_Rubro_Descripcion
from gd_esquema.Maestra
where Publicacion_Rubro_Descripcion is not null

--------------------------- FIN RUBRO