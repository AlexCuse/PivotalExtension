﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PivotalTrackerDotNet.Domain;

namespace PivotalTrackerDotNet {
	public class MemberShipService:AAuthenticatedService {
		const string MemberShipEndpoint = "projects/{0}/memberships";
		public MemberShipService(AuthenticationToken token) : base(token) {
		}

		public List<Person> GetMembers(int projectId) {
			var request = BuildRequest();
			request.Resource = string.Format(MemberShipEndpoint, projectId);
			var response = RestClient.Execute<List<Person>>(request);
			return response.Data;
		}
	}
}