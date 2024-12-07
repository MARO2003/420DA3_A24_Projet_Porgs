using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

internal class RoleService {

    private readonly RoleDAO dao;
    private readonly RoleView view;


    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public RoleService(ProjectApplication parentApp, WsysDbContext context) {
        this.dao = new RoleDAO(context);
        this.view = new RoleView(parentApp);
    }


    public Role? OpenUserWindowForCreation() {
        Role newRole = (Role) FormatterServices.GetUninitializedObject(typeof(Role));
        DialogResult result = this.view.OpenForCreation(newRole);
        return result == DialogResult.OK ? newRole : null;
    }


    public Role? OpenUserWindowForDetailsView(Role role) {
        DialogResult result = this.view.OpenForDetailsView(role);
        return result == DialogResult.OK ? role : null;
    }

    public Role? OpenUserWindowForEdition(Role role) {
        DialogResult result = this.view.OpenForEdition(role);
        return result == DialogResult.OK ? role : null;
    }


    public Role? OpenUserWindowForDeletion(Role role) {
        DialogResult result = this.view.OpenForDeletion(role);
        return result == DialogResult.OK ? role : null;
    }


    public List<Role> GetAll(bool includeDeleted = false) {
        return this.dao.GetAll(includeDeleted);
    }

    public Role? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

 
    public Role? GetByRoleName(string roleName, bool includeDeleted = false) {
        return this.dao.GetByRoleName(roleName, includeDeleted);
    }


    public List<Role> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Role Create(Role role) {
        return this.dao.Create(role);
    }


    public Role Update(Role role) {
        return this.dao.Update(role);
    }

    public Role Delete(Role role, bool softDeletes = true) {
        return this.dao.Delete(role, softDeletes);
    }

}
