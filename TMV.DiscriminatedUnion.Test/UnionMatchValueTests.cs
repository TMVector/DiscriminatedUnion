using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TMV.DiscriminatedUnion.Test
{
	[TestClass]
	public class UnionMatchValueTests
	{
		#region Union<A> Match tests
		[TestMethod]
		public void UnionAValueA()
		{
			const int val = 111;
			Union<int> union = new Union<int>(val);
			bool matched = union.Match(
				(int i) => true
			);

			Assert.IsTrue(matched);
		}
		#endregion

		
		#region Union<A, B> Match tests
		[TestMethod]
		public void UnionBValueA()
		{
			const int val = 111;
			Union<int, Type1> union = new Union<int, Type1>(val);
			bool matched = union.Match(
				(int i) => i == val,
				(Type1 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionBValueB()
		{
			const int val = 111;
			Union<Type1, int> union = new Union<Type1, int>(val);
			bool matched = union.Match(
				(Type1 s) => false,
				(int i) => i == val
			);

			Assert.IsTrue(matched);
		}
		#endregion

		
		#region Union<A, B, C> Match tests
		[TestMethod]
		public void UnionCValueA()
		{
			const int val = 111;
			Union<int, Type1, Type2> union = new Union<int, Type1, Type2>(val);
			bool matched = union.Match(
				(int i) => i == val,
				(Type1 t) => false,
				(Type2 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionCValueB()
		{
			const int val = 111;
			Union<Type1, int, Type2> union = new Union<Type1, int, Type2>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(int i) => i == val,
				(Type2 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionCValueC()
		{
			const int val = 111;
			Union<Type1, Type2, int> union = new Union<Type1, Type2, int>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(int i) => i == val
			);

			Assert.IsTrue(matched);
		}
		#endregion

		
		#region Union<A, B, C, D> Match tests
		[TestMethod]
		public void UnionDValueA()
		{
			const int val = 111;
			Union<int, Type1, Type2, Type3> union = new Union<int, Type1, Type2, Type3>(val);
			bool matched = union.Match(
				(int i) => i == val,
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionDValueB()
		{
			const int val = 111;
			Union<Type1, int, Type2, Type3> union = new Union<Type1, int, Type2, Type3>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(int i) => i == val,
				(Type2 t) => false,
				(Type3 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionDValueC()
		{
			const int val = 111;
			Union<Type1, Type2, int, Type3> union = new Union<Type1, Type2, int, Type3>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(int i) => i == val,
				(Type3 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionDValueD()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, int> union = new Union<Type1, Type2, Type3, int>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(int i) => i == val
			);

			Assert.IsTrue(matched);
		}
		#endregion

		
		#region Union<A, B, C, D, E> Match tests
		[TestMethod]
		public void UnionEValueA()
		{
			const int val = 111;
			Union<int, Type1, Type2, Type3, Type4> union = new Union<int, Type1, Type2, Type3, Type4>(val);
			bool matched = union.Match(
				(int i) => i == val,
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionEValueB()
		{
			const int val = 111;
			Union<Type1, int, Type2, Type3, Type4> union = new Union<Type1, int, Type2, Type3, Type4>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(int i) => i == val,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionEValueC()
		{
			const int val = 111;
			Union<Type1, Type2, int, Type3, Type4> union = new Union<Type1, Type2, int, Type3, Type4>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(int i) => i == val,
				(Type3 t) => false,
				(Type4 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionEValueD()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, int, Type4> union = new Union<Type1, Type2, Type3, int, Type4>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(int i) => i == val,
				(Type4 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionEValueE()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, Type4, int> union = new Union<Type1, Type2, Type3, Type4, int>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false,
				(int i) => i == val
			);

			Assert.IsTrue(matched);
		}
		#endregion


		#region Union<A, B, C, D, E, F> Match tests
		[TestMethod]
		public void UnionFValueA()
		{
			const int val = 111;
			Union<int, Type1, Type2, Type3, Type4, Type5> union = new Union<int, Type1, Type2, Type3, Type4, Type5>(val);
			bool matched = union.Match(
				(int i) => i == val,
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false,
				(Type5 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionFValueB()
		{
			const int val = 111;
			Union<Type1, int, Type2, Type3, Type4, Type5> union = new Union<Type1, int, Type2, Type3, Type4, Type5>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(int i) => i == val,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false,
				(Type5 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionFValueC()
		{
			const int val = 111;
			Union<Type1, Type2, int, Type3, Type4, Type5> union = new Union<Type1, Type2, int, Type3, Type4, Type5>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(int i) => i == val,
				(Type3 t) => false,
				(Type4 t) => false,
				(Type5 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionFValueD()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, int, Type4, Type5> union = new Union<Type1, Type2, Type3, int, Type4, Type5>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(int i) => i == val,
				(Type4 t) => false,
				(Type5 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionFValueE()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, Type4, int, Type5> union = new Union<Type1, Type2, Type3, Type4, int, Type5>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false,
				(int i) => i == val,
				(Type5 t) => false
			);

			Assert.IsTrue(matched);
		}
		[TestMethod]
		public void UnionFValueF()
		{
			const int val = 111;
			Union<Type1, Type2, Type3, Type4, Type5, int> union = new Union<Type1, Type2, Type3, Type4, Type5, int>(val);
			bool matched = union.Match(
				(Type1 t) => false,
				(Type2 t) => false,
				(Type3 t) => false,
				(Type4 t) => false,
				(Type5 t) => false,
				(int i) => i == val
			);

			Assert.IsTrue(matched);
		}
		#endregion
	}
}
