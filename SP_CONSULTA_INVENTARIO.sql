create or alter procedure SP_CONSULTA_INVENTARIO
	@codCia VARCHAR(5) = NULL,
	@companiaVenta3 VARCHAR(5) = NULL,
	@almacenVenta VARCHAR(10) = NULL,
	@tipoMovimiento VARCHAR(2) = NULL,
	@tipoDocumento VARCHAR(2) = NULL,
	@nroDocumento VARCHAR(50) = NULL,
	@codItem2 VARCHAR(50) = NULL,
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
	SELECT COD_CIA, COMPANIA_VENTA_3, ALMACEN_VENTA, TIPO_MOVIMIENTO, TIPO_DOCUMENTO, NRO_DOCUMENTO, COD_ITEM_2, PROVEEDOR, ALMACEN_DESTINO, CANTIDAD, DOC_REF_1, DOC_REF_2, DOC_REF_3, DOC_REF_4, DOC_REF_5, FECHA_TRANSACCION 
	FROM MOV_INVENTARIO
	WHERE (@codCia IS NULL OR COD_CIA = @codCia)
	AND (@companiaVenta3 IS NULL OR COMPANIA_VENTA_3 = @companiaVenta3)
	AND (@almacenVenta IS NULL OR ALMACEN_VENTA = @almacenVenta)
	AND (@tipoMovimiento IS NULL OR TIPO_MOVIMIENTO = @tipoMovimiento)
	AND (@tipoDocumento IS NULL OR TIPO_DOCUMENTO = @tipoDocumento)
	AND (@nroDocumento IS NULL OR NRO_DOCUMENTO = @nroDocumento)
	AND (@codItem2 IS NULL OR COD_ITEM_2 = @codItem2)
	AND (@proveedor IS NULL OR PROVEEDOR = @proveedor)
	AND (@almacenDestino IS NULL OR ALMACEN_DESTINO = @almacenDestino)
	AND (@cantidad IS NULL OR CANTIDAD = @cantidad)
	AND (@docRef1 IS NULL OR DOC_REF_1 = @docRef1)
	AND (@docRef2 IS NULL OR DOC_REF_2 = @docRef2)
	AND (@docRef3 IS NULL OR DOC_REF_3 = @docRef3)
	AND (@docRef4 IS NULL OR DOC_REF_4 = @docRef4)
	AND (@docRef5 IS NULL OR DOC_REF_5 = @docRef5)
	AND (@fechaTransaccion IS NULL OR FECHA_TRANSACCION = @fechaTransaccion)
end;