using System.Collections.Generic;
using System.Linq;
using GAI.BusinessLogic.DataModel;

namespace GAI.BusinessLogic.Services
{
    public class PoliceDepartmentsService
    {
        public List<PoliceDepartment> GetPoliceDepartments()
        {
            using (var entity = new GAIEntities())
            {
                var listOfPD = entity.PoliceDepartments.ToList();
                return listOfPD;
            }
        }
    }
}
