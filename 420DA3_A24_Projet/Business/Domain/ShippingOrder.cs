using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain
{
    public class ShippingOrder {
        #region champs prives
        //Champs prives pour proprietes de validation
        private int id;
        private int sourceClientId;
        private int creatorEmployeeId;
        private int destinationAdressId;
        #endregion 
        #region proprietes publiques
        public int Id {
            get { return this.id; }
            set {
                if (!ValidateId(value)) {
                    throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
                }
                this.id = value;
            }
        }
        public ShippingOrderStatusEnum Status { get; set; }
        public int SourceClientId {
            get { return this.sourceClientId; }
            set {
                if (!ValidateId(value)) {
                    throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
                }
                this.sourceClientId = value;
            }
        }
        public int CreatorEmployeeId {
            get { return this.creatorEmployeeId; }
            set {
                if (!ValidateId(value)) {
                    throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
                }
                this.creatorEmployeeId = value;
            }
        }
        public int DestinationAddressId {
            get { return this.destinationAdressId; }
            set {
                if (!ValidateId(value)) {
                    throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
                }
                this.destinationAdressId = value;
            }
        }
        public int? FulfillerEmployeeId { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }
        public byte[] RowVersion { get; set; } = null;

        public virtual Shipment? Shipment { get; set; }
        public  virtual User CreatorEmployee { get; set; }
        public virtual User? FulfillerEmployee { get; set; }
        public virtual Adresse DestinationAddress { get; set; }

        public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; } = new List<ShippingOrderProduct>();

        #endregion
        #region constructeurs
        /// <summary>
        /// Constructeur orienté création utilisateur
        /// </summary>
        /// <param name="sourceClientId">L'id du  Client</param>
        /// <param name="creatorEmployeeId">L'id de L'employe qui cree l'ordre</param>
        /// <param name="destinationAdressId">L'id de l'adresse.</param>
        /// <param name="fulfillerEmployeeId">L'id de l'employee en charge de l'ordre.</param>
        public ShippingOrder(int sourceClientId, int creatorEmployeeId, int destinationAdressId, int fulfillerEmployeeId) { 
            this.SourceClientId = sourceClientId;
            this.CreatorEmployeeId = creatorEmployeeId;
            this.DestinationAddressId= destinationAdressId;
            this.FulfillerEmployeeId= fulfillerEmployeeId;
        }

        /// <summary>
        /// Constructeur orienté création utilisateur
        /// </summary>
        /// <param name="id">L'identifiant de lordre de commande.</param>
        /// <param name="sourceClientId">L'id du  Client</param>
        /// <param name="creatorEmployeeId">L'id de L'employe qui cree l'ordre</param>
        /// <param name="destinationAdressId">L'id de l'adresse.</param>
        /// <param name="fulfillerEmployeeId">L'id de l'employee en charge de l'ordre.</param>
        /// <param name="dateCreated">La date de création de l'utilisateur dans la base de données.</param>
        /// <param name="dateModified">La date de dernière modification de l'utilisateur dans la base de données.</param>
        /// <param name="dateDeleted">La date de suppression de l'utilisateur dans la base de données.</param>
        /// <param name="rowVersion">Le numéro de version anti-concurrence de l'entrée dans la base de donnée.</param>
        public ShippingOrder(int id,
            int sourceClientId,
            int creatorEmployeeId,
            int destinationAdressId,
            int fulfillerEmployeeId,
             DateTime dateCreated,
            DateTime? dateModified,
            DateTime? dateDeleted,
            byte[] rowVersion) 
            :this(
             sourceClientId,
             creatorEmployeeId,
             destinationAdressId,
             fulfillerEmployeeId){

            this.Id = id;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.DateDeleted = dateDeleted;
            this.RowVersion = rowVersion;

        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode de validation d'ID
        /// </summary>
        /// <param name="id">Le numéro d'ID à valider</param>
        /// <returns><see langword="true"/> si valide, <see langword="false"/> sinon.</returns>
        public static bool ValidateId(int id) {
            return id >= 0;
        }

       

        #endregion
    }
}
