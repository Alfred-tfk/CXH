using System;
namespace CXH.Model
{
	
	public  class UserInfo
	{
		public UserInfo()
		{}
	
        private int _Id;       
		private string _username;
		private string _password;
		private string _qq;
		private string _email;
		private string _type="普通用户";
		private string _userimg;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{
              
                    _username = value;
                         
               }
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserImg
		{
			set{ _userimg=value;}
			get{return _userimg;}
		}
	

	}
}

