using InventarioDinet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventarioDinet.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index()
        {
            DbModelEntities context = new DbModelEntities();
            var resultado = context.SP_CONSULTA_INVENTARIO(
                    codCia: null, 
                    companiaVenta3: null, 
                    almacenVenta: null, 
                    tipoMovimiento: null, 
                    tipoDocumento: null, 
                    nroDocumento: null, 
                    codItem2: null,
                    proveedor: null, 
                    almacenDestino: null, 
                    cantidad: null, 
                    docRef1: null, 
                    docRef2: null, 
                    docRef3: null, 
                    docRef4: null, 
                    docRef5: null, 
                    fechaTransaccion: null
            ).ToList();
            return View(context.MOV_INVENTARIO.ToList());
        }

        // GET: Inventory/Details/5
        public ActionResult Details(string codCia, string companiaVenta3, string almacenVenta, string tipoMovimiento, string tipoDocumento, string nroDocumento, string codItem2)
        {
            DbModelEntities context = new DbModelEntities();
            return View(context.MOV_INVENTARIO.Where(x =>
                x.COD_CIA == codCia &&
                x.COMPANIA_VENTA_3 == companiaVenta3 &&
                x.ALMACEN_VENTA == almacenVenta &&
                x.TIPO_MOVIMIENTO == tipoMovimiento &&
                x.TIPO_DOCUMENTO == tipoDocumento &&
                x.NRO_DOCUMENTO == nroDocumento &&
                x.COD_ITEM_2 == codItem2).FirstOrDefault());
        }

        // GET: Inventory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Inventory/Create
        [HttpPost]
        public ActionResult Create(MOV_INVENTARIO inventario)
        {
            try
            {
                DbModelEntities context = new DbModelEntities();
                context.MOV_INVENTARIO.Add(inventario);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventory/Edit/5
        public ActionResult Edit(string codCia, string companiaVenta3, string almacenVenta, string tipoMovimiento, string tipoDocumento, string nroDocumento, string codItem2)
        {
            DbModelEntities context = new DbModelEntities();
            return View(context.MOV_INVENTARIO.Where(x =>
                x.COD_CIA == codCia &&
                x.COMPANIA_VENTA_3 == companiaVenta3 &&
                x.ALMACEN_VENTA == almacenVenta &&
                x.TIPO_MOVIMIENTO == tipoMovimiento &&
                x.TIPO_DOCUMENTO == tipoDocumento &&
                x.NRO_DOCUMENTO == nroDocumento &&
                x.COD_ITEM_2 == codItem2).FirstOrDefault());
        }

        // POST: Inventory/Edit/5
        [HttpPost]
        public ActionResult Edit(string codCia, string companiaVenta3, string almacenVenta, string tipoMovimiento, string tipoDocumento, string nroDocumento, string codItem2, MOV_INVENTARIO inventario)
        {
            try
            {
                DbModelEntities context = new DbModelEntities();
                context.Entry(inventario).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Inventory/Delete/5
        public ActionResult Delete(string codCia, string companiaVenta3, string almacenVenta, string tipoMovimiento, string tipoDocumento, string nroDocumento, string codItem2)
        {
            DbModelEntities context = new DbModelEntities();
            return View(context.MOV_INVENTARIO.Where(x =>
                x.COD_CIA == codCia &&
                x.COMPANIA_VENTA_3 == companiaVenta3 &&
                x.ALMACEN_VENTA == almacenVenta &&
                x.TIPO_MOVIMIENTO == tipoMovimiento &&
                x.TIPO_DOCUMENTO == tipoDocumento &&
                x.NRO_DOCUMENTO == nroDocumento &&
                x.COD_ITEM_2 == codItem2).FirstOrDefault());
        }

        // POST: Inventory/Delete/5
        [HttpPost]
        public ActionResult Delete(string codCia, string companiaVenta3, string almacenVenta, string tipoMovimiento, string tipoDocumento, string nroDocumento, string codItem2, FormCollection collection)
        {
            try
            {
                DbModelEntities context = new DbModelEntities();
                MOV_INVENTARIO inventario = context.MOV_INVENTARIO.Where(x =>
                                            x.COD_CIA == codCia &&
                                            x.COMPANIA_VENTA_3 == companiaVenta3 &&
                                            x.ALMACEN_VENTA == almacenVenta &&
                                            x.TIPO_MOVIMIENTO == tipoMovimiento &&
                                            x.TIPO_DOCUMENTO == tipoDocumento &&
                                            x.NRO_DOCUMENTO == nroDocumento &&
                                            x.COD_ITEM_2 == codItem2).FirstOrDefault();
                context.MOV_INVENTARIO.Remove(inventario);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
