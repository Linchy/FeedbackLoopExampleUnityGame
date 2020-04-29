using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FL_UnityEngine.WSA
{
	public unsafe partial class Tile {
		public static FL_UnityEngine.WSA.Tile CreateOrUpdateSecondary(UnityEngine.WSA.SecondaryTileData data) => throw new NotImplementedException();
		public static FL_UnityEngine.WSA.Tile CreateOrUpdateSecondary(UnityEngine.WSA.SecondaryTileData data, UnityEngine.Vector2 pos) => throw new NotImplementedException();
		public static FL_UnityEngine.WSA.Tile CreateOrUpdateSecondary(UnityEngine.WSA.SecondaryTileData data, UnityEngine.Rect area) => throw new NotImplementedException();
		public void Delete() => throw new NotImplementedException();
		public void Delete(UnityEngine.Vector2 pos) => throw new NotImplementedException();
		public void Delete(UnityEngine.Rect area) => throw new NotImplementedException();
		public static void DeleteSecondary(string tileId) => throw new NotImplementedException();
		public static void DeleteSecondary(string tileId, UnityEngine.Vector2 pos) => throw new NotImplementedException();
		public static void DeleteSecondary(string tileId, UnityEngine.Rect area) => throw new NotImplementedException();
		public static bool Exists(string tileId) => throw new NotImplementedException();
		public static FL_UnityEngine.WSA.Tile[] GetSecondaries() => throw new NotImplementedException();
		public static FL_UnityEngine.WSA.Tile GetSecondary(string tileId) => throw new NotImplementedException();
		public static string GetTemplate(UnityEngine.WSA.TileTemplate templ) => throw new NotImplementedException();
		public void PeriodicBadgeUpdate(string uri, float interval) => throw new NotImplementedException();
		public void PeriodicUpdate(string uri, float interval) => throw new NotImplementedException();
		public void RemoveBadge() => throw new NotImplementedException();
		public void StopPeriodicBadgeUpdate() => throw new NotImplementedException();
		public void StopPeriodicUpdate() => throw new NotImplementedException();
		public void Update(string xml) => throw new NotImplementedException();
		public void Update(string medium, string wide, string large, string text) => throw new NotImplementedException();
		public void UpdateBadgeImage(string image) => throw new NotImplementedException();
		public void UpdateBadgeNumber(float number) => throw new NotImplementedException();
		public bool exists => throw new NotImplementedException();
		public bool hasUserConsent => throw new NotImplementedException();
		public string id => throw new NotImplementedException();
		public static FL_UnityEngine.WSA.Tile main => throw new NotImplementedException();
	}
}
