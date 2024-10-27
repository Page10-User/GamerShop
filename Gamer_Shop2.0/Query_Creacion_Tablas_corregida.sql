CREATE TABLE Cliente
(
  ID_Cliente INT IDENTITY NOT NULL,
  DNI VARCHAR(8) NOT NULL,
  Nombre VARCHAR(35) NOT NULL,
  Apellido VARCHAR(35) NOT NULL,
  Teléfono VARCHAR(15) NOT NULL,
  Correo VARCHAR NOT NULL,
  CONSTRAINT PK_Cliente PRIMARY KEY (ID_Cliente),
  CONSTRAINT UQ_DNICliente UNIQUE (DNI),
  CONSTRAINT UQ_TelefonoCliente UNIQUE (Teléfono),
  CONSTRAINT UQ_CorreoCliente UNIQUE (Correo)
);


CREATE TABLE Método_pago
(
  ID_Método INT IDENTITY NOT NULL,
  Descripción VARCHAR(25) NOT NULL,
  CONSTRAINT PK_MétodoPago PRIMARY KEY (ID_Método)
);

CREATE TABLE Tipo_usuario
(
  ID_TipoUsuario INT IDENTITY NOT NULL,
  Descripción VARCHAR(15) NOT NULL,
  CONSTRAINT PK_TipoUsuario PRIMARY KEY (ID_TipoUsuario)
);




CREATE TABLE Usuario
(
  ID_Usuario INT IDENTITY NOT NULL,
  Nombre VARCHAR(35) NOT NULL,
  Apellido VARCHAR(35) NOT NULL,
  CUIL VARCHAR(12) NOT NULL,
  Nombre_usuario VARCHAR(20) NOT NULL,
  Contraseña VARCHAR(20) NOT NULL,
  Correo VARCHAR(50) NOT NULL,
  photoFilePath VARCHAR(200),
  ID_TipoUsuario INT NOT NULL,
  Activo VARCHAR(2) NOT NULL DEFAULT 'SI',
  CONSTRAINT PK_Usuario PRIMARY KEY (ID_Usuario),
  CONSTRAINT FK_TipoUsuario FOREIGN KEY (ID_TipoUsuario) REFERENCES Tipo_usuario(ID_TipoUsuario),
  CONSTRAINT UQ_CUILUsuario UNIQUE (CUIL),
  CONSTRAINT UQ_NombreUsuarioUsuario UNIQUE (Nombre_usuario),
  CONSTRAINT UQ_ContraseñaUsuario UNIQUE (Contraseña),
  CONSTRAINT UQ_CorreoUsuario UNIQUE (Correo)
);


CREATE TABLE Venta
(
  ID_Venta INT IDENTITY NOT NULL,
  Fecha DATE NOT NULL,
  Total FLOAT NOT NULL,
  ID_Usuario INT NOT NULL,
  ID_Cliente INT NOT NULL,
  ID_Método INT NOT NULL,
  CONSTRAINT PK_Venta PRIMARY KEY (ID_Venta),
  CONSTRAINT FK_UsuarioVenta FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario),
  CONSTRAINT FK_ClienteVenta FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
  CONSTRAINT FK_MetodoPagoVenta FOREIGN KEY (ID_Método) REFERENCES Método_pago(ID_Método)
);


CREATE TABLE Detalle_venta
(
  Subtotal FLOAT NOT NULL,
  Cantidad INT NOT NULL,
  Precio_actual FLOAT NOT NULL,
  ID_Producto INT NOT NULL,
  ID_Venta INT NOT NULL,
  CONSTRAINT PK_DetalleVenta PRIMARY KEY (ID_Producto, ID_Venta),
  CONSTRAINT FK_ProductoDV FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto),
  CONSTRAINT FK_VentaDV FOREIGN KEY (ID_Venta) REFERENCES Venta(ID_Venta)
);


CREATE TABLE Compra
(
  ID_Compra INT IDENTITY NOT NULL,
  Fecha DATE NOT NULL,
  Total FLOAT NOT NULL,
  ID_Proveedor INT NOT NULL,
  ID_Usuario INT NOT NULL,
  CONSTRAINT PK_Compra PRIMARY KEY (ID_Compra),
  CONSTRAINT FK_ProveedorCompra FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor),
  CONSTRAINT FK_UsuarioCompra FOREIGN KEY (ID_Usuario) REFERENCES Usuario(ID_Usuario)
);


CREATE TABLE Detalle_compra
(
  Subtotal FLOAT NOT NULL,
  Cantidad INT NOT NULL,
  Precio_actual INT NOT NULL,
  ID_Producto INT NOT NULL,
  ID_Compra INT NOT NULL,
  CONSTRAINT PK_DetalleCompra PRIMARY KEY (ID_Producto, ID_Compra),
  CONSTRAINT FK_ProductoDC FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto),
  CONSTRAINT FK_CompraDC FOREIGN KEY (ID_Compra) REFERENCES Compra(ID_Compra)
);

