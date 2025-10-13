using System.ComponentModel.DataAnnotations;

namespace Layer_Domain.Entities.Items
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }

        public int CharId { get; set; }
        public CHARACTER Character { get; set; } = null!;

        public int Currency_CP { get; set; } = 0;
        public int Currency_SP { get; set; } = 0;
        public int Currency_EP { get; set; } = 0;
        public int Currency_GP { get; set; } = 0;
        public int Currency_PP { get; set; } = 0;

        public List<BankItem> BankItems { get; set; } = new();
    }

    public class BankItem
    {
        [Key]
        public int BankItemId { get; set; }

        public int BankId { get; set; }
        public Bank Bank { get; set; } = null!;

        public int ItemId { get; set; }
        public ITEM Item { get; set; } = null!;

        public int Quantity { get; set; } = 1;
    }
}
