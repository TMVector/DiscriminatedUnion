using System;
using System.Diagnostics.Contracts;

namespace TMV.DiscriminatedUnion
{
	public class Union<A>
	{
		private readonly A value;
		public Union(A value)
		{
			this.value = value;
		}
		public void Match(Action<A> fa)
		{
			Contract.Requires(fa != null);

			fa(value);
		}
		public T Match<T>(Func<A, T> fa)
		{
			Contract.Requires(fa != null);

			return fa(value);
		}
	}

	public class Union<A, B>
	{
		private readonly object value;
		private readonly bool isA;
		public Union(A value)
		{
			this.value = value;
			isA = true;
		}
		public Union(B value)
		{
			this.value = value;
			isA = false;
		}
		public void Match(Action<A> fa, Action<B> fb)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);

			if (isA)
				fa((A)value);
			else
				fb((B)value);
		}
		public T Match<T>(Func<A, T> fa, Func<B, T> fb)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);

			if (isA)
				return fa((A)value);
			else
				return fb((B)value);
		}
	}

	public class Union<A, B, C>
	{
		private readonly object value;
		private readonly int id;
		public Union(A value)
		{
			this.value = value;
			id = 0;
		}
		public Union(B value)
		{
			this.value = value;
			id = 1;
		}
		public Union(C value)
		{
			this.value = value;
			id = 2;
		}
		public void Match(Action<A> fa, Action<B> fb, Action<C> fc)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: fa((A)value); break;
				case 1: fb((B)value); break;
				case 2: fc((C)value); break;
			}
		}
		public T Match<T>(Func<A, T> fa, Func<B, T> fb, Func<C, T> fc)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: return fa((A)value);
				case 1: return fb((B)value);
				case 2: return fc((C)value);
			}
			throw new InvalidOperationException("Union in invalid state - internal id of " + id);
		}

		[ContractInvariantMethod]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
		private void ObjectInvariant()
		{
			Contract.Invariant(IsIdInBounds());
		}
		private bool IsIdInBounds()
		{
			return 0 <= id && id <= 2;
		}
	}

	public class Union<A, B, C, D>
	{
		private readonly object value;
		private readonly int id;
		public Union(A value)
		{
			this.value = value;
			id = 0;
		}
		public Union(B value)
		{
			this.value = value;
			id = 1;
		}
		public Union(C value)
		{
			this.value = value;
			id = 2;
		}
		public Union(D value)
		{
			this.value = value;
			id = 3;
		}
		public void Match(Action<A> fa, Action<B> fb, Action<C> fc, Action<D> fd)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Requires(fd != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: fa((A)value); break;
				case 1: fb((B)value); break;
				case 2: fc((C)value); break;
				case 3: fd((D)value); break;
			}
		}
		public T Match<T>(Func<A, T> fa, Func<B, T> fb, Func<C, T> fc, Func<D, T> fd)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Requires(fd != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: return fa((A)value);
				case 1: return fb((B)value);
				case 2: return fc((C)value);
				case 3: return fd((D)value);
			}
			throw new InvalidOperationException("Union in invalid state - internal id of " + id);
		}

		[ContractInvariantMethod]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
		private void ObjectInvariant()
		{
			Contract.Invariant(IsIdInBounds());
		}
		private bool IsIdInBounds()
		{
			return 0 <= id && id <= 3;
		}
	}

	public class Union<A, B, C, D, E>
	{
		private readonly object value;
		private readonly int id;
		public Union(A value)
		{
			this.value = value;
			id = 0;
		}
		public Union(B value)
		{
			this.value = value;
			id = 1;
		}
		public Union(C value)
		{
			this.value = value;
			id = 2;
		}
		public Union(D value)
		{
			this.value = value;
			id = 3;
		}
		public Union(E value)
		{
			this.value = value;
			id = 4;
		}
		public void Match(Action<A> fa, Action<B> fb, Action<C> fc, Action<D> fd, Action<E> fe)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Requires(fd != null);
			Contract.Requires(fe != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: fa((A)value); break;
				case 1: fb((B)value); break;
				case 2: fc((C)value); break;
				case 3: fd((D)value); break;
				case 4: fe((E)value); break;
			}
		}
		public T Match<T>(Func<A, T> fa, Func<B, T> fb, Func<C, T> fc, Func<D, T> fd, Func<E, T> fe)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Requires(fd != null);
			Contract.Requires(fe != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: return fa((A)value);
				case 1: return fb((B)value);
				case 2: return fc((C)value);
				case 3: return fd((D)value);
				case 4: return fe((E)value);
			}
			throw new InvalidOperationException("Union in invalid state - internal id of " + id);
		}

		[ContractInvariantMethod]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
		private void ObjectInvariant()
		{
			Contract.Invariant(IsIdInBounds());
		}
		private bool IsIdInBounds()
		{
			return 0 <= id && id <= 4;
		}
	}

	public class Union<A, B, C, D, E, F>
	{
		private readonly object value;
		private readonly int id;
		public Union(A value)
		{
			this.value = value;
			id = 0;
		}
		public Union(B value)
		{
			this.value = value;
			id = 1;
		}
		public Union(C value)
		{
			this.value = value;
			id = 2;
		}
		public Union(D value)
		{
			this.value = value;
			id = 3;
		}
		public Union(E value)
		{
			this.value = value;
			id = 4;
		}
		public Union(F value)
		{
			this.value = value;
			id = 5;
		}
		public void Match(Action<A> fa, Action<B> fb, Action<C> fc, Action<D> fd, Action<E> fe, Action<F> ff)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Requires(fd != null);
			Contract.Requires(fe != null);
			Contract.Requires(ff != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: fa((A)value); break;
				case 1: fb((B)value); break;
				case 2: fc((C)value); break;
				case 3: fd((D)value); break;
				case 4: fe((E)value); break;
				case 5: ff((F)value); break;
			}
		}
		public T Match<T>(Func<A, T> fa, Func<B, T> fb, Func<C, T> fc, Func<D, T> fd, Func<E, T> fe, Func<F, T> ff)
		{
			Contract.Requires(fa != null);
			Contract.Requires(fb != null);
			Contract.Requires(fc != null);
			Contract.Requires(fd != null);
			Contract.Requires(fe != null);
			Contract.Requires(ff != null);
			Contract.Assert(IsIdInBounds());

			switch (id)
			{
				case 0: return fa((A)value);
				case 1: return fb((B)value);
				case 2: return fc((C)value);
				case 3: return fd((D)value);
				case 4: return fe((E)value);
				case 5: return ff((F)value);
			}
			throw new InvalidOperationException("Union in invalid state - internal id of " + id);
		}

		[ContractInvariantMethod]
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Required for code contracts.")]
		private void ObjectInvariant()
		{
			Contract.Invariant(IsIdInBounds());
		}
		private bool IsIdInBounds()
		{
			return 0 <= id && id <= 5;
		}
	}
}
