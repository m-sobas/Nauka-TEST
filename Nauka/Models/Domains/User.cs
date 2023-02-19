using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Nauka.Models.Domains
{
	public class User
	{
		public User()
		{
			Groups = new Collection<Group>();
		}

		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<Group> Groups { get; set; }
	}
}
