namespace Investment.Domain.Entities.Core
{
    public class FamilyMember : Person
    {
        public FamilyMember()
        {
            PersonType = "FamilyMember";
        }

        public bool IsEarning { get; set; }
    }
}
