using System;
using PlayFab.SharedModels;

namespace PlayFab.AdminModels
{
	[Serializable]
	public class GetDataReportResult : PlayFabResultCommon
	{
		public string DownloadUrl;
	}
}