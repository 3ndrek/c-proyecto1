USE [PAV_3K2_2022_12]
GO
/****** Object:  Table [dbo].[camarotes]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[camarotes](
	[cod_navio] [int] NOT NULL,
	[num_cubierta] [int] NOT NULL,
	[num_camarote] [int] NOT NULL,
	[tipo] [int] NULL,
	[monto] [int] NULL,
	[cant_camas] [int] NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_camarotes] PRIMARY KEY CLUSTERED 
(
	[cod_navio] ASC,
	[num_cubierta] ASC,
	[num_camarote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[camarotesXviajes]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[camarotesXviajes](
	[cod_navio] [int] NOT NULL,
	[num_cubierta] [int] NOT NULL,
	[num_camarote] [int] NOT NULL,
	[fecha_viaje] [date] NOT NULL,
	[ocupacion] [int] NOT NULL,
	[autovalorCorrector] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_camarotesXviajes] PRIMARY KEY CLUSTERED 
(
	[cod_navio] ASC,
	[num_camarote] ASC,
	[num_cubierta] ASC,
	[fecha_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoriasItinerarios]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoriasItinerarios](
	[categoria] [int] NOT NULL,
	[descripcion] [nvarchar](50) NULL,
	[precio_base] [int] NULL,
 CONSTRAINT [PK_categoriasItinerarios] PRIMARY KEY CLUSTERED 
(
	[categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ciudades]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ciudades](
	[cod_ciudad] [int] NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[esDadoBaja] [nchar](10) NULL,
 CONSTRAINT [PK_ciudades] PRIMARY KEY CLUSTERED 
(
	[cod_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clasificacion_navios]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clasificacion_navios](
	[cod] [int] NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_clasificacion_navios] PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cobros]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cobros](
	[nro_reserva] [int] NOT NULL,
	[modo_pago] [int] NOT NULL,
	[monto] [int] NOT NULL,
	[fecha_pago] [date] NOT NULL,
	[nro_factura] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_cobros_1] PRIMARY KEY CLUSTERED 
(
	[nro_reserva] ASC,
	[fecha_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cubiertas]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cubiertas](
	[cod_navio] [int] NOT NULL,
	[num_cubierta] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](max) NULL,
	[leg_encargado] [int] NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_cubiertas] PRIMARY KEY CLUSTERED 
(
	[cod_navio] ASC,
	[num_cubierta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[genero]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genero](
	[tipo] [int] NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_genero] PRIMARY KEY CLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[itinerarios]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[itinerarios](
	[cod_itinerario] [int] IDENTITY(20,1) NOT NULL,
	[categoria] [int] NULL,
	[nombre] [nvarchar](max) NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_itinerarios] PRIMARY KEY CLUSTERED 
(
	[cod_itinerario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[modosPagos]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modosPagos](
	[modo_pago] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_modosPagos] PRIMARY KEY CLUSTERED 
(
	[modo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[navio]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[navio](
	[codigo_navio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[altura] [int] NULL,
	[eslora] [int] NULL,
	[manga] [int] NULL,
	[desplazamiento] [int] NULL,
	[autonomia] [int] NULL,
	[cant_camarotes] [int] NULL,
	[cant_max_pasajeros] [int] NULL,
	[cant_motores] [int] NULL,
	[cant_tripulantes] [int] NULL,
	[clasificacion] [int] NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_navio] PRIMARY KEY CLUSTERED 
(
	[codigo_navio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ocupacionCamarotes]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ocupacionCamarotes](
	[tipo_ocupacion] [int] NOT NULL,
	[descripcion] [nchar](50) NULL,
 CONSTRAINT [PK_ocupacionCamarotes] PRIMARY KEY CLUSTERED 
(
	[tipo_ocupacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paises]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paises](
	[cod_pais] [int] NOT NULL,
	[nombre] [nchar](10) NOT NULL,
	[esDadoBja] [nchar](10) NULL,
 CONSTRAINT [PK_paises] PRIMARY KEY CLUSTERED 
(
	[cod_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paisesXciudades]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paisesXciudades](
	[cod_pais] [int] NOT NULL,
	[cod_ciudad] [int] NOT NULL,
 CONSTRAINT [PK_paisesXciudades] PRIMARY KEY CLUSTERED 
(
	[cod_pais] ASC,
	[cod_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pasajeros]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pasajeros](
	[tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[nombre] [nvarchar](max) NULL,
	[apellido] [nvarchar](max) NULL,
	[ciudad_procedente] [int] NULL,
	[pais_procedente] [int] NULL,
	[email] [nvarchar](max) NULL,
	[fechaNac] [datetime] NULL,
	[genero] [int] NULL,
	[estáDadoBaja] [int] NULL,
 CONSTRAINT [PK_pasajeros] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[num_doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pasajerosXcamarotes]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pasajerosXcamarotes](
	[cod_navios] [int] NOT NULL,
	[num_cubierta] [int] NOT NULL,
	[num_camarote] [int] NOT NULL,
	[tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[fecha_viaje] [int] NOT NULL,
 CONSTRAINT [PK_pasajerosXcamarotes] PRIMARY KEY CLUSTERED 
(
	[cod_navios] ASC,
	[fecha_viaje] ASC,
	[num_camarote] ASC,
	[tipo_doc] ASC,
	[num_doc] ASC,
	[num_cubierta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pasajeroXreservaciones]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pasajeroXreservaciones](
	[tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[nro_reserva] [int] NOT NULL,
	[estado_reserva] [nchar](1) NULL,
	[nro_cobro_reservacion] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_pasajeroXreservaciones] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[num_doc] ASC,
	[nro_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfiles]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfiles](
	[Id_perfil] [int] NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_perfiles] PRIMARY KEY CLUSTERED 
(
	[Id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puertos]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puertos](
	[cod_puerto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](max) NOT NULL,
	[esDAdoBaja] [nchar](10) NULL,
 CONSTRAINT [PK_puertos] PRIMARY KEY CLUSTERED 
(
	[cod_puerto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puertosXpaises]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puertosXpaises](
	[cod_puerto] [int] NOT NULL,
	[cod_pais] [int] NOT NULL,
 CONSTRAINT [PK_puertosXpaises] PRIMARY KEY CLUSTERED 
(
	[cod_puerto] ASC,
	[cod_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puertoXitinerarios]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puertoXitinerarios](
	[cod_itinerarios] [int] NOT NULL,
	[num_escala] [int] NOT NULL,
	[cod_puerto] [int] NOT NULL,
 CONSTRAINT [PK_puertoXitinerarios] PRIMARY KEY CLUSTERED 
(
	[cod_itinerarios] ASC,
	[num_escala] ASC,
	[cod_puerto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puestos]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puestos](
	[cod_puesto] [int] NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_puestos] PRIMARY KEY CLUSTERED 
(
	[cod_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservaciones]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservaciones](
	[cod_navio] [int] NOT NULL,
	[num_cubierta] [int] NOT NULL,
	[num_camarotes] [int] NOT NULL,
	[fecha_viaje] [date] NOT NULL,
	[cama_ocupada] [int] NULL,
	[tipo_doc] [int] NOT NULL,
	[num_doc] [int] NOT NULL,
	[PrecioReserva] [int] NULL,
	[nro_reservacion] [int] IDENTITY(2,10) NOT NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_reservaciones_1] PRIMARY KEY CLUSTERED 
(
	[nro_reservacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_doc]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_doc](
	[tipo] [int] NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_tipo_doc] PRIMARY KEY CLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoCamarote]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoCamarote](
	[tipo] [int] NOT NULL,
	[descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_tipoCamarote] PRIMARY KEY CLUSTERED 
(
	[tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tripulantes]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tripulantes](
	[legajo] [int] IDENTITY(10,5) NOT NULL,
	[jefe] [int] NULL,
	[nombre] [nvarchar](max) NULL,
	[apellido] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
	[fechaNac] [datetime] NULL,
	[puesto] [int] NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_tripulantes] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[usuario] [nvarchar](50) NOT NULL,
	[contraseña] [nchar](10) NULL,
	[perfil] [int] NULL,
	[esDadoBaja] [int] NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[viaje]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viaje](
	[cod_navio] [int] NOT NULL,
	[fecha_viaje] [date] NOT NULL,
	[duracion] [int] NULL,
	[cod_itinerario] [int] NULL,
	[esDadoBa] [int] NULL,
 CONSTRAINT [PK_viaje] PRIMARY KEY CLUSTERED 
(
	[cod_navio] ASC,
	[fecha_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[viajesXtripulantes]    Script Date: 14/11/2022 16:33:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viajesXtripulantes](
	[legajo] [int] NOT NULL,
	[cod_navio] [int] NOT NULL,
	[fechaviaje] [date] NOT NULL,
 CONSTRAINT [PK_viajesXtripulantes] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC,
	[cod_navio] ASC,
	[fechaviaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[camarotes]  WITH CHECK ADD  CONSTRAINT [FK_camarotes_cubiertas1] FOREIGN KEY([cod_navio], [num_cubierta])
REFERENCES [dbo].[cubiertas] ([cod_navio], [num_cubierta])
GO
ALTER TABLE [dbo].[camarotes] CHECK CONSTRAINT [FK_camarotes_cubiertas1]
GO
ALTER TABLE [dbo].[camarotes]  WITH CHECK ADD  CONSTRAINT [FK_camarotes_tipoCamarote] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipoCamarote] ([tipo])
GO
ALTER TABLE [dbo].[camarotes] CHECK CONSTRAINT [FK_camarotes_tipoCamarote]
GO
ALTER TABLE [dbo].[camarotesXviajes]  WITH CHECK ADD  CONSTRAINT [FK_camarotesXviajes_camarotes1] FOREIGN KEY([cod_navio], [num_cubierta], [num_camarote])
REFERENCES [dbo].[camarotes] ([cod_navio], [num_cubierta], [num_camarote])
GO
ALTER TABLE [dbo].[camarotesXviajes] CHECK CONSTRAINT [FK_camarotesXviajes_camarotes1]
GO
ALTER TABLE [dbo].[camarotesXviajes]  WITH CHECK ADD  CONSTRAINT [FK_camarotesXviajes_ocupacionCamarotes] FOREIGN KEY([ocupacion])
REFERENCES [dbo].[ocupacionCamarotes] ([tipo_ocupacion])
GO
ALTER TABLE [dbo].[camarotesXviajes] CHECK CONSTRAINT [FK_camarotesXviajes_ocupacionCamarotes]
GO
ALTER TABLE [dbo].[cobros]  WITH CHECK ADD  CONSTRAINT [FK_cobros_reservaciones] FOREIGN KEY([nro_reserva])
REFERENCES [dbo].[reservaciones] ([nro_reservacion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[cobros] CHECK CONSTRAINT [FK_cobros_reservaciones]
GO
ALTER TABLE [dbo].[cobros]  WITH CHECK ADD  CONSTRAINT [FK_reservaciones_modosPagos] FOREIGN KEY([modo_pago])
REFERENCES [dbo].[modosPagos] ([modo_pago])
GO
ALTER TABLE [dbo].[cobros] CHECK CONSTRAINT [FK_reservaciones_modosPagos]
GO
ALTER TABLE [dbo].[cubiertas]  WITH CHECK ADD  CONSTRAINT [FK_cubiertas_navio] FOREIGN KEY([cod_navio])
REFERENCES [dbo].[navio] ([codigo_navio])
GO
ALTER TABLE [dbo].[cubiertas] CHECK CONSTRAINT [FK_cubiertas_navio]
GO
ALTER TABLE [dbo].[itinerarios]  WITH CHECK ADD  CONSTRAINT [FK_itinerarios_categoriasItinerarios] FOREIGN KEY([categoria])
REFERENCES [dbo].[categoriasItinerarios] ([categoria])
GO
ALTER TABLE [dbo].[itinerarios] CHECK CONSTRAINT [FK_itinerarios_categoriasItinerarios]
GO
ALTER TABLE [dbo].[navio]  WITH CHECK ADD  CONSTRAINT [FK_navio_clasificacion_navios] FOREIGN KEY([clasificacion])
REFERENCES [dbo].[clasificacion_navios] ([cod])
GO
ALTER TABLE [dbo].[navio] CHECK CONSTRAINT [FK_navio_clasificacion_navios]
GO
ALTER TABLE [dbo].[paisesXciudades]  WITH CHECK ADD  CONSTRAINT [FK_paisesXciudades_ciudades] FOREIGN KEY([cod_ciudad])
REFERENCES [dbo].[ciudades] ([cod_ciudad])
GO
ALTER TABLE [dbo].[paisesXciudades] CHECK CONSTRAINT [FK_paisesXciudades_ciudades]
GO
ALTER TABLE [dbo].[paisesXciudades]  WITH CHECK ADD  CONSTRAINT [FK_paisesXciudades_paises] FOREIGN KEY([cod_pais])
REFERENCES [dbo].[paises] ([cod_pais])
GO
ALTER TABLE [dbo].[paisesXciudades] CHECK CONSTRAINT [FK_paisesXciudades_paises]
GO
ALTER TABLE [dbo].[pasajeros]  WITH CHECK ADD  CONSTRAINT [FK_pasajeros_genero] FOREIGN KEY([genero])
REFERENCES [dbo].[genero] ([tipo])
GO
ALTER TABLE [dbo].[pasajeros] CHECK CONSTRAINT [FK_pasajeros_genero]
GO
ALTER TABLE [dbo].[pasajeros]  WITH CHECK ADD  CONSTRAINT [FK_pasajeros_paisesXciudades] FOREIGN KEY([pais_procedente], [ciudad_procedente])
REFERENCES [dbo].[paisesXciudades] ([cod_pais], [cod_ciudad])
GO
ALTER TABLE [dbo].[pasajeros] CHECK CONSTRAINT [FK_pasajeros_paisesXciudades]
GO
ALTER TABLE [dbo].[pasajeros]  WITH CHECK ADD  CONSTRAINT [FK_pasajeros_tipo_doc] FOREIGN KEY([tipo_doc])
REFERENCES [dbo].[tipo_doc] ([tipo])
GO
ALTER TABLE [dbo].[pasajeros] CHECK CONSTRAINT [FK_pasajeros_tipo_doc]
GO
ALTER TABLE [dbo].[pasajerosXcamarotes]  WITH CHECK ADD  CONSTRAINT [FK_pasajerosXcamarotes_camarotes] FOREIGN KEY([cod_navios], [num_cubierta], [num_camarote])
REFERENCES [dbo].[camarotes] ([cod_navio], [num_cubierta], [num_camarote])
GO
ALTER TABLE [dbo].[pasajerosXcamarotes] CHECK CONSTRAINT [FK_pasajerosXcamarotes_camarotes]
GO
ALTER TABLE [dbo].[pasajerosXcamarotes]  WITH CHECK ADD  CONSTRAINT [FK_pasajerosXcamarotes_pasajeros] FOREIGN KEY([tipo_doc], [num_doc])
REFERENCES [dbo].[pasajeros] ([tipo_doc], [num_doc])
GO
ALTER TABLE [dbo].[pasajerosXcamarotes] CHECK CONSTRAINT [FK_pasajerosXcamarotes_pasajeros]
GO
ALTER TABLE [dbo].[pasajeroXreservaciones]  WITH CHECK ADD  CONSTRAINT [FK_pasajeroXreservaciones_pasajeros] FOREIGN KEY([nro_reserva])
REFERENCES [dbo].[reservaciones] ([nro_reservacion])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pasajeroXreservaciones] CHECK CONSTRAINT [FK_pasajeroXreservaciones_pasajeros]
GO
ALTER TABLE [dbo].[pasajeroXreservaciones]  WITH CHECK ADD  CONSTRAINT [FK_pasajeroXreservaciones_pasajeros1] FOREIGN KEY([tipo_doc], [num_doc])
REFERENCES [dbo].[pasajeros] ([tipo_doc], [num_doc])
GO
ALTER TABLE [dbo].[pasajeroXreservaciones] CHECK CONSTRAINT [FK_pasajeroXreservaciones_pasajeros1]
GO
ALTER TABLE [dbo].[puertosXpaises]  WITH CHECK ADD  CONSTRAINT [FK_puertosXpaises_paises] FOREIGN KEY([cod_pais])
REFERENCES [dbo].[paises] ([cod_pais])
GO
ALTER TABLE [dbo].[puertosXpaises] CHECK CONSTRAINT [FK_puertosXpaises_paises]
GO
ALTER TABLE [dbo].[puertosXpaises]  WITH CHECK ADD  CONSTRAINT [FK_puertosXpaises_puertos] FOREIGN KEY([cod_puerto])
REFERENCES [dbo].[puertos] ([cod_puerto])
GO
ALTER TABLE [dbo].[puertosXpaises] CHECK CONSTRAINT [FK_puertosXpaises_puertos]
GO
ALTER TABLE [dbo].[puertoXitinerarios]  WITH CHECK ADD  CONSTRAINT [FK_puertoXitinerarios_itinerarios] FOREIGN KEY([cod_itinerarios])
REFERENCES [dbo].[itinerarios] ([cod_itinerario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[puertoXitinerarios] CHECK CONSTRAINT [FK_puertoXitinerarios_itinerarios]
GO
ALTER TABLE [dbo].[puertoXitinerarios]  WITH CHECK ADD  CONSTRAINT [FK_puertoXitinerarios_puertos] FOREIGN KEY([cod_puerto])
REFERENCES [dbo].[puertos] ([cod_puerto])
GO
ALTER TABLE [dbo].[puertoXitinerarios] CHECK CONSTRAINT [FK_puertoXitinerarios_puertos]
GO
ALTER TABLE [dbo].[reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservaciones_camarotes] FOREIGN KEY([cod_navio], [num_cubierta], [num_camarotes])
REFERENCES [dbo].[camarotes] ([cod_navio], [num_cubierta], [num_camarote])
GO
ALTER TABLE [dbo].[reservaciones] CHECK CONSTRAINT [FK_reservaciones_camarotes]
GO
ALTER TABLE [dbo].[reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservaciones_pasajeros] FOREIGN KEY([tipo_doc], [num_doc])
REFERENCES [dbo].[pasajeros] ([tipo_doc], [num_doc])
GO
ALTER TABLE [dbo].[reservaciones] CHECK CONSTRAINT [FK_reservaciones_pasajeros]
GO
ALTER TABLE [dbo].[reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_reservaciones_viaje] FOREIGN KEY([cod_navio], [fecha_viaje])
REFERENCES [dbo].[viaje] ([cod_navio], [fecha_viaje])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[reservaciones] CHECK CONSTRAINT [FK_reservaciones_viaje]
GO
ALTER TABLE [dbo].[tripulantes]  WITH CHECK ADD  CONSTRAINT [FK_tripulantes_puestos] FOREIGN KEY([puesto])
REFERENCES [dbo].[puestos] ([cod_puesto])
GO
ALTER TABLE [dbo].[tripulantes] CHECK CONSTRAINT [FK_tripulantes_puestos]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_perfiles] FOREIGN KEY([perfil])
REFERENCES [dbo].[perfiles] ([Id_perfil])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_perfiles]
GO
ALTER TABLE [dbo].[viaje]  WITH CHECK ADD  CONSTRAINT [FK_viaje_itinerarios] FOREIGN KEY([cod_itinerario])
REFERENCES [dbo].[itinerarios] ([cod_itinerario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[viaje] CHECK CONSTRAINT [FK_viaje_itinerarios]
GO
ALTER TABLE [dbo].[viaje]  WITH CHECK ADD  CONSTRAINT [FK_viaje_navio] FOREIGN KEY([cod_navio])
REFERENCES [dbo].[navio] ([codigo_navio])
GO
ALTER TABLE [dbo].[viaje] CHECK CONSTRAINT [FK_viaje_navio]
GO
ALTER TABLE [dbo].[viajesXtripulantes]  WITH CHECK ADD  CONSTRAINT [FK_viajesXtripulantes_tripulantes] FOREIGN KEY([legajo])
REFERENCES [dbo].[tripulantes] ([legajo])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[viajesXtripulantes] CHECK CONSTRAINT [FK_viajesXtripulantes_tripulantes]
GO
ALTER TABLE [dbo].[viajesXtripulantes]  WITH CHECK ADD  CONSTRAINT [FK_viajesXtripulantes_viaje] FOREIGN KEY([cod_navio], [fechaviaje])
REFERENCES [dbo].[viaje] ([cod_navio], [fecha_viaje])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[viajesXtripulantes] CHECK CONSTRAINT [FK_viajesXtripulantes_viaje]
GO
