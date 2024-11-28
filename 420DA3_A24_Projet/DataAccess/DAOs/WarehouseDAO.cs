using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Dao de l'entite WareHouse.
/// </summary>
internal class WarehouseDAO {
    private readonly WsysDbContext context;

    /// <summary>
    ///nouvellw instance de WarehouseDAO .
    /// </summary>
    /// <param name="context">Database context.</param>
    public WarehouseDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Retrieves a warehouse by its ID.
    /// </summary>
    /// <param name="id">id de warehouse.</param>
    /// <param name="includeDeleted">.</param>
    /// <returns>The warehouse if found, or null.</returns>
    public Warehouse? GetById(int id, bool includeDeleted = false) {
        return this.context.Warehouses
            .Where(warehouse => warehouse.Id == id && (includeDeleted || warehouse.DateDeleted == null))
            .Include(warehouse => warehouse.Clients)
            .Include(warehouse => warehouse.Address)
            .Include(warehouse => warehouse.RestockOrders)
            .Include(warehouse => warehouse.WarehouseEmployees)
            .SingleOrDefault();
    }

    /// <summary>
    /// Retrieves a list of warehouses by name.
    /// </summary>
    /// <param name="name">nom de warehouse.</param>
    /// <param name="includeDeleted"></param>
    /// <returns>La liste de warehouse</returns>
    public List<Warehouse> GetByName(string name, bool includeDeleted = false) {
        return this.context.Warehouses
            .Where(warehouse => warehouse.Name.Contains(name) && (includeDeleted || warehouse.DateDeleted == null))
            .Include(warehouse => warehouse.Clients)
            .Include(warehouse => warehouse.Address)
            .Include(warehouse => warehouse.RestockOrders)
            .Include(warehouse => warehouse.WarehouseEmployees)
            .ToList();
    }

    /// <summary>
    /// creer une warehouse.
    /// </summary>
    /// <param name="warehouse">Le nom de la warehouse.</param>
    /// <returns>le warehouse.</returns>
    public Warehouse Create(Warehouse warehouse) {
        _ = this.context.Warehouses.Add(warehouse);
        _ = this.context.SaveChanges();
        return warehouse;
    }

    /// <summary>
    /// Modifier warehouse.
    /// </summary>
    /// <param name="warehouse">le nom de warehouse.</param>
    /// <returns>le warehouse mis a jour.</returns>
    public Warehouse Update(Warehouse warehouse) {
        warehouse.DateModified = DateTime.Now;
        _ = this.context.Warehouses.Update(warehouse);
        _ = this.context.SaveChanges();
        return warehouse;
    }

    /// <summary>
    /// Suppression de warehouse
    /// </summary>
    /// <param name="warehouse">Le nom de warehouse a delete</param>
    /// <param name="softDeletes">.</param>
    /// <returns>Le warehouse supprime.</returns>
    public Warehouse Delete(Warehouse warehouse, bool softDeletes = true) {
        if (softDeletes) {
            warehouse.DateDeleted = DateTime.Now;
            _ = this.context.Warehouses.Update(warehouse);
        } else {
            _ = this.context.Warehouses.Remove(warehouse);
        }
        _ = this.context.SaveChanges();
        return warehouse;
    }

    /// <summary>
    /// chercher a partir dun criterion.
    /// </summary>
    /// <param name="criterion">le criterion </param>
    /// <param name="includeDeleted">.</param>
    /// <returns>Liste de warehouse correspondant au criterion</returns>
    public List<Warehouse> Search(string criterion, bool includeDeleted = false) {
        return this.context.Warehouses
            .Where(w =>
                w.Id.ToString().Contains(criterion) ||
                w.Name.ToLower().Contains(criterion.ToLower())
            && (includeDeleted || w.DateDeleted == null))
            .Include(w => w.Clients)
            .Include(w => w.Address)
            .Include(w => w.RestockOrders)
            .Include(w => w.WarehouseEmployees)
            .ToList();
    }
}
