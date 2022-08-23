using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityProject.EntityClasses.Models
{
    
    public abstract class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
    }

    public class Unit: BaseEntity
    {
        [Display(Name = "Название")]
        public string Name { get; set; }

        public virtual List<Tmc> AllTmc { get; set; }
    }

    public class Login: BaseEntity
    {
        [DisplayName("Имя пользователя")]
        public string Name { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }

        public virtual List<Tmc> AllTmc { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual List<DocumentIn> AllDocumentIn { get; set; }
        public virtual List<DocumentInItems> AllDocumentInItems { get; set; }
        public virtual List<DocumentOut> AllDocumentOut { get; set; }
        public virtual List<DocumentOutItems> AllDocumentOutItems { get; set; }
        public virtual List<DocumentMoneyIn> AllDocumentMoneyIn { get; set; }
        public virtual List<DocumentMoneyInItems> AllDocumentMoneyInItems { get; set; }
        public virtual List<DocumentMoneyOut> AllDocumentMoneyOut { get; set; }
        public virtual List<DocumentMoneyOutItems> AllDocumentMoneyOutItems { get; set; }
        public virtual List<FormSetting> AllFormSetting { get; set; }
    }

    public class TmcGroup: BaseEntity
    {
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Корневая группа")]
        public int GroupId { get; set; }

        public virtual List<Tmc> AllTmc { get; set; }
    }

    public class Tmc: BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public double Price { get; set; }
        public double Price1 { get; set; }
        public double Price2 { get; set; }
        public int UnitId { get; set; }
        public double MinQuantity { get; set; }
        public string Note { get; set; }
        public int LoginId { get; set; }
        public DateTime RecordDate { get; set; }

        public virtual TmcGroup TmcGroup { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Login Login { get; set; }

        public virtual List<DocumentInItems> AllDocumentInItems { get; set; }
        public virtual List<DocumentOutItems> AllDocumentOutItems { get; set; }

    }

    public class Customer: BaseEntity
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Info { get; set; }
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
        public virtual List<DocumentIn> AllDocumentIn { get; set; }
        public virtual List<DocumentOut> AllDocumentOut { get; set; }
        public virtual List<DocumentMoneyIn> AllDocumentMoneyIn { get; set; }
        public virtual List<DocumentMoneyOut> AllDocumentMoneyOut { get; set; }
    }

    public class DocumentIn : BaseEntity
    {
        public bool Done { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public decimal Suma { get; set; }
        public string Note { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<DocumentInItems> AllDocumentInItems { get; set; }
    }

    public class DocumentInItems: BaseEntity
    {
        public int DocumentInId { get; set; }
        public int TmcId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Suma { get; set; }
        public int LoginId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Tmc Tmc { get; set; }
        public virtual DocumentIn DocumentIn { get; set; }
        public virtual Login Login { get; set; }
    }

    public class DocumentOut : BaseEntity
    {
        public bool Done { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public decimal Suma { get; set; }
        public string Note { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<DocumentOutItems> AllDocumentOutItems { get; set; }
    }

    public class DocumentOutItems: BaseEntity
    {
        public int DocumentOutId { get; set; }
        public int TmcId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double Suma { get; set; }
        public int LoginId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual Tmc Tmc { get; set; }
        public virtual DocumentOut DocumentOut { get; set; }
        public virtual Login Login { get; set; }

    }

    public class DocumentMoneyIn : BaseEntity
    {
        public bool Done { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public decimal Suma { get; set; }
        public string Note { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<DocumentMoneyInItems> AllDocumentMoneyInItems { get; set; }
    }

    public class DocumentMoneyInItems: BaseEntity
    {
        public int DocumentMoneyInId { get; set; }
        public bool Cashless { get; set; }
        public double Suma { get; set; }
        public int LoginId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DocumentMoneyIn DocumentMoneyIn { get; set; }
        public virtual Login Login { get; set; }
    }

    public class DocumentMoneyOut : BaseEntity
    {
        public bool Done { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public decimal Suma { get; set; }
        public string Note { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime CreateDate { get; set; }
        public int LoginId { get; set; }

        public virtual Login Login { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<DocumentMoneyOutItems> AllDocumentMoneyOutItems { get; set; }
    }

    public class DocumentMoneyOutItems: BaseEntity
    {
        public int DocumentMoneyOutId { get; set; }
        public bool Cashless { get; set; }
        public double Suma { get; set; }
        public int LoginId { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual DocumentMoneyOut DocumentMoneyOut { get; set; }
        public virtual Login Login { get; set; }
    }

    public class FormSetting: BaseEntity
    {
        public int FormId { get; set; }
        public int LoginId { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int WindowState { get; set; }

        public virtual Login Login { get; set; }
    }

   

}
