using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Classe DAO pour gérer les opérations liées à l'entité ShippingOrder (ordre d'expédition).
/// </summary>
internal class ShippingOrderDAO {
    private  WsysDbContext context;

    /// <summary>
    /// Constructeur qui initialise la classe
    /// </summary>
    /// <param name="context">Le contexte de base de données.</param>
    public ShippingOrderDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Récupère un ordre d'expédition en function de id
    /// </summary>
    /// <param name="id">L'id de l'ordre.</param>
    /// <param name="includeDeleted">.</param>
    /// <returns>L'ordre d'expédition Trouve.</returns>
    public ShippingOrder? GetById(int id, bool includeDeleted = false) {
        return this.context.ShippingOrders
            .Where(so => so.Id == id && (includeDeleted || so.DateDeleted == null))
            .Include(so => so.CreatorEmployee)
            .Include(so => so.FulfillerEmployee)
            .Include(so => so.DestinationAddress)
            .Include(so => so.ShippingOrderProducts)
            .Include(so => so.Shipment)
            .SingleOrDefault();
    }

    /// <summary>
    /// Récupère tous les ordres d'expédition dun client.
    /// </summary>
    /// <param name="clientId">L'identifiant du client.</param>
    /// <param name="includeDeleted">.</param>
    /// <returns>Une liste des ordres d'expédition dun client.</returns>
    public List<ShippingOrder> GetByClientId(int clientId, bool includeDeleted = false) {
        return this.context.ShippingOrders
            .Where(so => so.SourceClientId == clientId && (includeDeleted || so.DateDeleted == null))
            .Include(so => so.CreatorEmployee)
            .Include(so => so.FulfillerEmployee)
            .Include(so => so.DestinationAddress)
            .Include(so => so.ShippingOrderProducts)
            .Include(so => so.Shipment)
            .ToList();
    }

    /// <summary>
    /// Crée un nouvel ordre d'expédition dans la base de données.
    /// </summary>
    /// <param name="shippingOrder">L'ordre d'expédition à ajouter.</param>
    /// <returns>L'ordre d'expédition créé.</returns>
    public ShippingOrder Create(ShippingOrder shippingOrder) {
        _ = this.context.ShippingOrders.Add(shippingOrder);
        _ = this.context.SaveChanges();
        return shippingOrder;
    }

    /// <summary>
    /// modifie
    /// </summary>
    /// <param name="shippingOrder">L'ordre d'expédition à mettre à jour.</param>
    /// <returns>L'ordre d'expédition mis à jour.</returns>
    public ShippingOrder Update(ShippingOrder shippingOrder) {
        shippingOrder.DateModified = DateTime.Now;
        _ = this.context.ShippingOrders.Update(shippingOrder);
        _ = this.context.SaveChanges();
        return shippingOrder;
    }

    /// <summary>
    /// Supprime un ordre d'expédition.
    /// </summary>
    /// <param name="shippingOrder">L'ordre d'expédition à supprimer.</param>
    /// <param name="softDeletes">Indique si la suppression doit être "douce" (soft delete).</param>
    /// <returns>L'ordre d'expédition supprimé.</returns>
    public ShippingOrder Delete(ShippingOrder shippingOrder, bool softDeletes = true) {
        if (softDeletes) {
            shippingOrder.DateDeleted = DateTime.Now;
            _ = this.context.ShippingOrders.Update(shippingOrder);
        } else {
            _ = this.context.ShippingOrders.Remove(shippingOrder);
        }
        _ = this.context.SaveChanges();
        return shippingOrder;
    }

    /// <summary>
    /// Recherche des ordres d'expédition en fonction d'un critère donné.
    /// </summary>
    /// <param name="criterion">Le critère de recherche <param>
    /// <param name="includeDeleted">.</param>
    /// <returns>liste dordre d'expedition satisfaisant le criterion.</returns>
    public List<ShippingOrder> Search(string criterion, bool includeDeleted = false) {
        return this.context.ShippingOrders
            .Where(so =>
                so.Id.ToString().Contains(criterion) ||
                so.SourceClientId.ToString().Contains(criterion)
                && (includeDeleted || so.DateDeleted == null))
            .Include(so => so.CreatorEmployee)
            .Include(so => so.FulfillerEmployee)
            .Include(so => so.DestinationAddress)
            .Include(so => so.ShippingOrderProducts)
            .Include(so => so.Shipment)
            .ToList();
    }
}
