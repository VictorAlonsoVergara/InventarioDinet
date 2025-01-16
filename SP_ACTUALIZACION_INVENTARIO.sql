create or alter procedure SP_ACTUALIZACION_INVENTARIO
	@codCia VARCHAR(5),
	@companiaVenta3 VARCHAR(5),
	@almacenVenta VARCHAR(10),
	@tipoMovimiento VARCHAR(2),
	@tipoDocumento VARCHAR(2),
	@nroDocumento VARCHAR(50),
	@codItem2 VARCHAR(50),
	@proveedor VARCHAR(100) = NULL,
	@almacenDestino VARCHAR(50) = NULL,
	@cantidad INT = NULL,
	@docRef1 VARCHAR(50) = NULL,
	@docRef2 VARCHAR(50) = NULL,
	@docRef3 VARCHAR(50) = NULL,
	@docRef4 VARCHAR(50) = NULL,
	@docRef5 VARCHAR(50) = NULL,
	@fechaTransaccion DATE = NULL
as
begin
	update MOV_INVENTARIO
	set PROVEEDOR = @proveedor, ALMACEN_DESTINO = @almacenDestino, CANTIDAD = @cantidad, DOC_REF_1 = @docRef1, DOC_REF_2 = @docRef2, DOC_REF_3 = @docRef3, DOC_REF_4 = @docRef4, DOC_REF_5 = @docRef5, FECHA_TRANSACCION = @fechaTransaccion
	where COD_CIA = @codCia
	and COMPANIA_VENTA_3 = @companiaVenta3
	and ALMACEN_VENTA = @almacenVenta 
	and TIPO_MOVIMIENTO = @tipoMovimiento
	and TIPO_DOCUMENTO = @tipoDocumento
	and NRO_DOCUMENTO = @nroDocumento
	and COD_ITEM_2 = @codItem2
end;