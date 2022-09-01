public abstract class CommercialBuildings
{
   public int NumofSpaceLeft {get;set;}=100;
 public abstract string GetBusinessPermit();

   public virtual string GetLocation()
   {
    return "Maitidevi, Kathmandu";
    
   }         
}