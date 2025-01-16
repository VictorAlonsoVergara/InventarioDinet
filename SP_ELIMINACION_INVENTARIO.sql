create or alter procedure SP_ELIMINACION_INVENTARIO
	@codCia VARCHAR(5),
	@companiaVenta3 VARCHAR(5),
	@almacenVenta VARCHAR(10),
	@tipoMovimiento VARCHAR(2),
	@tipoDocumento VARCHAR(2),
	@nroDocumento VARCHAR(50),
	@codItem2 VARCHAR(50)
as
begin
	delete
	from MOV_INVENTARIO
	where COD_CIA = @codCia
	and COMPANIA_VENTA_3 = @companiaVenta3
	and ALMACEN_VENTA = @almacenVenta 
	and TIPO_MOVIMIENTO = @tipoMovimiento
	and TIPO_DOCUMENTO = @tipoDocumento
	and NRO_DOCUMENTO = @nroDocumento
	and COD_ITEM_2 = @codItem2
end;