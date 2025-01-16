create or alter procedure SP_INSERCION_INVENTARIO
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
	insert into MOV_INVENTARIO(COD_CIA,COMPANIA_VENTA_3,ALMACEN_VENTA,TIPO_MOVIMIENTO,TIPO_DOCUMENTO,NRO_DOCUMENTO,COD_ITEM_2,PROVEEDOR,ALMACEN_DESTINO,CANTIDAD,DOC_REF_1,DOC_REF_2,DOC_REF_3,DOC_REF_4,DOC_REF_5,FECHA_TRANSACCION)
	values (@codCia,@companiaVenta3,@almacenVenta,@tipoMovimiento,@tipoDocumento,@nroDocumento,@codItem2,@proveedor,@almacenDestino,@cantidad,@docRef1,@docRef2,@docRef3,@docRef4,@docRef5,@fechaTransaccion);
end;