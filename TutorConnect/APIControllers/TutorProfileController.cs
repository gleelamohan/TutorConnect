using System.Collections.Generic;
using System.Web.Http;
using Breeze.WebApi2;
using TutorConnect.Models;
using TutorConnectBusinessContracts;



namespace TutorConnect.APIControllers
{
    [BreezeController]
    public class TutorProfileController : ApiController
    {

        private readonly ITutorConnectBusiness _repository;

    // Use constructor injection here
         public TutorProfileController(ITutorConnectBusiness repository)
        {
            this._repository = repository;
        }

        [HttpPost]
        public void InsertTutorDetails(TutorProfileModel lstTutorProfile)
        {
           
           
        }

       
    }
}