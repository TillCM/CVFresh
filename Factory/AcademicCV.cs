using Microsoft.AspNetCore.Mvc;

namespace cvFresh;

public class AcademicCV : ICVFresh
{
    public List<string> getBiographicalDetails()
    {
        List<string> experience = new List<string>();

        experience.Add("10 years Prog");
        return experience;
    }

    public List<string> getEducation()
    {
        throw new NotImplementedException();
    }

    public List<string> getExperience()
    {
        throw new NotImplementedException();
    }

    public List<string> getReferecnes()
    {
        throw new NotImplementedException();
    }

    public List<string> getSkills()
    {
        throw new NotImplementedException();
    }
}