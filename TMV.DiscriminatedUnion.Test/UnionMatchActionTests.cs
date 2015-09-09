using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TMV.DiscriminatedUnion.Test
{
	[TestClass]
	public class UnionMatchActionTests
	{
		#region Union<A> Match tests
		[TestMethod]
		public void UnionAActionA()
		{
			const int val = 111;
			Union<int> union = new Union<int>(val);
			union.Match(
				(int i) => Assert.AreEqual(val, i)
			);
		}
		#endregion

		
		#region Union<A, B> Match tests
		[TestMethod]
		public void UnionBActionA()
		{
			const int val = 111;
			Union<int, Type1> union = new Union<int, Type1>(val);
			union.Match(
				(int i) => Assert.AreEqual(val, i),
				(Type1 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionBActionB()
		{
			const int val = 111;
			Union<Type1, int> union = new Union<Type1, int>(val);
			union.Match(
				(Type1 s) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i)
			);
		}
		#endregion

		
		#region Union<A, B, C> Match tests
		[TestMethod]
		public void UnionCActionA()
		{
			const int val = 111;
			Union<int, Type1, Type2> union = new Union<int, Type1, Type2>(val);
			union.Match(
				(int i) => Assert.AreEqual(val, i),
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionCActionB()
		{
			const int val = 111;
			Union<Type1, int, Type2> union = new Union<Type1, int, Type2>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type2 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionCActionC()
		{
			const int val = 111;
			Union<Type1, Type2, int> union = new Union<Type1, Type2, int>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i)
			);
		}
		#endregion

		
		#region Union<A, B, C, D> Match tests
		[TestMethod]
		public void UnionDActionA()
		{
			const int val = 111;
			Union<int, Type1, Type2, Type3> union = new Union<int, Type1, Type2, Type3>(val);
			union.Match(
				(int i) => Assert.AreEqual(val, i),
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionDActionB()
		{
			const int val = 111;
			Union<Type1, int, Type2, Type3> union = new Union<Type1, int, Type2, Type3>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionDActionC()
		{
			const int val = 111;
			Union<Type1, Type2, int, Type3> union = new Union<Type1, Type2, int, Type3>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type3 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionDActionD()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, int> union = new Union<Type1, Type2, Type3, int>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i)
			);
		}
		#endregion

		
		#region Union<A, B, C, D, E> Match tests
		[TestMethod]
		public void UnionEActionA()
		{
			const int val = 111;
			Union<int, Type1, Type2, Type3, Type4> union = new Union<int, Type1, Type2, Type3, Type4>(val);
			union.Match(
				(int i) => Assert.AreEqual(val, i),
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionEActionB()
		{
			const int val = 111;
			Union<Type1, int, Type2, Type3, Type4> union = new Union<Type1, int, Type2, Type3, Type4>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionEActionC()
		{
			const int val = 111;
			Union<Type1, Type2, int, Type3, Type4> union = new Union<Type1, Type2, int, Type3, Type4>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionEActionD()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, int, Type4> union = new Union<Type1, Type2, Type3, int, Type4>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type4 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionEActionE()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, Type4, int> union = new Union<Type1, Type2, Type3, Type4, int>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i)
			);
		}
		#endregion


		#region Union<A, B, C, D, E, F> Match tests
		[TestMethod]
		public void UnionFActionA()
		{
			const int val = 111;
			Union<int, Type1, Type2, Type3, Type4, Type5> union = new Union<int, Type1, Type2, Type3, Type4, Type5>(val);
			union.Match(
				(int i) => Assert.AreEqual(val, i),
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail(),
				(Type5 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionFActionB()
		{
			const int val = 111;
			Union<Type1, int, Type2, Type3, Type4, Type5> union = new Union<Type1, int, Type2, Type3, Type4, Type5>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail(),
				(Type5 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionFActionC()
		{
			const int val = 111;
			Union<Type1, Type2, int, Type3, Type4, Type5> union = new Union<Type1, Type2, int, Type3, Type4, Type5>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail(),
				(Type5 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionFActionD()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, int, Type4, Type5> union = new Union<Type1, Type2, Type3, int, Type4, Type5>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type4 t) => Assert.Fail(),
				(Type5 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionFActionE()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, Type4, int, Type5> union = new Union<Type1, Type2, Type3, Type4, int, Type5>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i),
				(Type5 t) => Assert.Fail()
			);
		}
		[TestMethod]
		public void UnionFActionF()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, Type4, Type5, int> union = new Union<Type1, Type2, Type3, Type4, Type5, int>(val);
			union.Match(
				(Type1 t) => Assert.Fail(),
				(Type2 t) => Assert.Fail(),
				(Type3 t) => Assert.Fail(),
				(Type4 t) => Assert.Fail(),
				(Type5 t) => Assert.Fail(),
				(int i) => Assert.AreEqual(val, i)
			);
		}
		#endregion
	}
}
