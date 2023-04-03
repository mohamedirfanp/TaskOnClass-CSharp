using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._31_03_2023
{
	public  class PhotoBook
	{
		public int numofpages = 0;

		public int num = 1;
		public PhotoBook()
		{
			this.numofpages = 16;
		}

		public PhotoBook(int no_of_pages)
		{
			this.numofpages = no_of_pages;
		}


		public int getNumPages()
		{

			return this.numofpages;

		}
	}

	public class AddPhotoBook : PhotoBook
	{

		public AddPhotoBook()
		{
			this.numofpages = 64;
		}

	}


}
