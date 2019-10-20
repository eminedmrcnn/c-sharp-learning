using System;
using System.Collections.Generic;
using System.Text;

namespace Döngüler14_10_19
{
	class Müsteri
	{
		public int Id { get; set; }
		private string _adi;
		public string Adi
		{
			get
			{
				return"Mr."+ _adi;
			}
			set
			{
				_adi = value;
			}
		}
		public string Soyadi { get; set; }
		public string Sehri { get; set; }
	}
}
