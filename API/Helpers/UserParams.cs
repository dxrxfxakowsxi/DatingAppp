using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class UserParams
    {
        private const int maxPageSize=50;
        public int PageNumber {get; set; }=1;
        private int _pageSize=10;

        public int PageSize
        {
            get => _pageSize;
            set => _pageSize=(value>maxPageSize) ? maxPageSize : value;
        }
        
        public string CurrentUserName { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; }=18;
        public int MaxAge { get; set; }=150;
        public string OrderBy { get; set; }="lastActive";
    }
}