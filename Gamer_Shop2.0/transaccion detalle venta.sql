CREATE TYPE [dbo].[EDetalle_venta] as table (
ID_Producto INT NOT NULL,
ID_Venta INT NOT NULL,
Subtotal FLOAT NOT NULL,
Cantidad INT NOT NULL,
Precio_actual FLOAT NOT NULL
)

CREATE PROCEDURE REGISTRARVENTA (
@ID_Usuario int,
@ID_Cliente int,
@ID_Método int,
@Fecha date,
@Total float,
@Detalle_venta [EDetalle_venta] READONLY
) as begin 
begin try
declare @ID_Venta int = 0
begin transaction registro

insert into Venta(ID_Usuario, ID_Cliente, ID_Método, Fecha, Total) VALUES (@ID_Usuario, @ID_Cliente, @ID_Cliente, @ID_Método, @Fecha, @Total)
SET @ID_Venta = SCOPE_IDENTITY()

INSERT INTO Detalle_venta (ID_Producto, ID_Venta, Subtotal, Cantidad, Precio_actual) SELECT @ID_Venta,ID_Producto,Subtotal,Cantidad,Precio_actual FROM @Detalle_venta

commit transaction registro
end try
begin catch
rollback transaction registro
end catch
end