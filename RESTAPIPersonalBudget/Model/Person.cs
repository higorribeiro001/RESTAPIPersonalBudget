using System.ComponentModel.DataAnnotations.Schema;
using RESTAPIPersonalBudget.Model.Base;

namespace RESTAPIPersonalBudget.Model
{
    [Table("person")]

    public class Person : BaseEntity
    {
        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        [Column("balance")]
        public decimal Balance { get; set; }
    }
}