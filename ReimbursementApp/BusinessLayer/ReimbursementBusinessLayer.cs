using Models;
using RepositoryAccessLayer;



namespace BusinessLayer
{
    public class ReimbursementBusinessLayer
    {

        private readonly ReimbursementRepoLayer _repoLayer;
        public ReimbursementBusinessLayer()
        {
            this._repoLayer = new ReimbursementRepoLayer();

        }



        public async Task<List<ReimbursementReq>> RequestsAsync(int type)
        {
            List<ReimbursementReq> list = await this._repoLayer.RequestsAsync(type);
            return list;
        }




          public async Task<UpdateReRequestDto> UpdateRequestAsync(ApprovalDto approvalDto)
        {
            if(await this._repoLayer.IsManagerAsync(approvalDto.EmployeeID))
            { 
               UpdateReRequestDto approvedRequest = await this._repoLayer.UpdateRequestAsync(approvalDto.ReimbursementID,approvalDto.Status);
            
               return approvedRequest;
           }

           else return null;
      }

    }
}