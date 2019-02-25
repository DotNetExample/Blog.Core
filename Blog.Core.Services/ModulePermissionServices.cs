using Blog.Core.Services.BASE;
using Blog.Core.Model.Models;
using Blog.Core.IRepository;
using Blog.Core.IServices;

namespace Blog.Core.Services
{	
	/// <summary>
	/// ModulePermissionServices
	/// </summary>	
	public class ModulePermissionServices : BaseServices<ModulePermission>, IModulePermissionServices
    {
	
        IModulePermissionRepository dal;
        public ModulePermissionServices(IModulePermissionRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }
       
    }
}
