
public abstract class ResidentialBuildings
{
    
 public int NumofResidenceLeft {get;set;}=100;
 public virtual void RentSpace(int numofSpaceRented)
 {
    NumofResidenceLeft = NumofResidenceLeft - numofSpaceRented;

 }
   public string GetBuildingAddress()
   {
    return "Chabahil,Kathmandu";
    
   }         
        
   
    
}