using Microsoft.AspNetCore.Mvc;

namespace cvFresh;

public interface ICVFresh
{
   List<String> getEducation();

   List<String> getExperience();

   List<String> getBiographicalDetails();

   List<String> getSkills();

   List<String> getReferecnes();

   
   

   

}