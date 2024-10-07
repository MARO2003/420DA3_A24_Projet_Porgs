﻿using _420DA3_A24_Exemple_Enseignant.Business.Domain;
using _420DA3_A24_Exemple_Enseignant.DataAccess.Contexts;

namespace _420DA3_A24_Exemple_Enseignant.DataAccess.Daos;
internal class MedecinDAO {
    private readonly ExempleDbContext context;

    public MedecinDAO(ExempleDbContext context) {
        this.context = context;
    }

    public List<Medecin> GetAllMedecins(bool includeDeleted = false) {
        return includeDeleted 
            ? this.context.Medecins.ToList() 
            : this.context.Medecins.Where(medecin => medecin.DateDeleted == null).ToList();
    }

    public Medecin? GetMedecinById(int id, bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Medecins.Where(medecin => medecin.Id == id).FirstOrDefault()
            : this.context.Medecins.Where(medecin => medecin.Id == id && medecin.DateDeleted == null).FirstOrDefault();
    }

    public Medecin UpdateMedecin(Medecin medecin) {
        medecin.DateModified = DateTime.UtcNow;
        _ = this.context.Medecins.Update(medecin);
        _ = this.context.SaveChanges();
        return medecin;
    }
}