CREATE TYPE [dbo].[EDetalle_compra] as table (
ID_Producto INT NOT NULL,
ID_Compra INT NOT NULL,
Subtotal FLOAT NOT NULL,
Cantidad INT NOT NULL,
Precio_actual FLOAT NOT NULL
)
go

CREATE PROCEDURE REGISTRARCOMPRA (
@ID_Usuario int,
@ID_Proveedor int,
@Fecha date,
@Total float,
@Detalle_compra [EDetalle_compra] READONLY
) as begin 
begin try
begin transaction registro
declare @ID_Compra

insert into Compra(ID_Usuario, ID_Proveedor, Fecha, Total) VALUES (@ID_Usuario, @ID_Proveedor, @Fecha, @Total)
SET @ID_Compra = SCOPE_IDENTITY()

INSERT INTO Detalle_compra(ID_Producto, ID_Compra, Subtotal, Cantidad, Precio_actual) SELECT ID_Producto, ID_Compra,Subtotal,Cantidad, Precio_actual FROM @Detalle_compra

commit transaction registro
end try
begin catch
ROLLBACK TRANSACTION registro;
    DECLARE @ErrorMessage NVARCHAR(4000);
    SET @ErrorMessage = ERROR_MESSAGE();
    RAISERROR(@ErrorMessage, 16, 1);
end catch
end