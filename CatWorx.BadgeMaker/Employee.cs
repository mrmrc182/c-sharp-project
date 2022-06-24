
namespace CatWorx.BadgeMaker
{
  class Employee 
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;
        public string CompanyName;
        public Employee(string firstName, string lastName, int empId, string photoUrl, string companyName){
            FirstName=firstName;
            LastName=lastName;
            Id=empId;
            PhotoUrl=photoUrl;
            CompanyName=companyName;
        }
        public string GetName(){
            return FirstName + " " + LastName;
        }
        public int GetId(){
            return Id;
        }
        public string GetPhotoUrl(){
            return PhotoUrl;
        }
        public string GetCompanyName(){
            return CompanyName;
        }
    }
}