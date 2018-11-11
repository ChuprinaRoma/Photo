using PhotoReport.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoReport.ModelView
{
    public class FirstPageMV
    {
        ManagerPhotoManager managerPhotoManager = null;
        
        public FirstPageMV()
        {
            managerPhotoManager = new ManagerPhotoManager();
        }
    }
}
