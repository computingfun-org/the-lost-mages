using System.Runtime.CompilerServices;

public enum ResourceID {
	Mana,
	Currency,
	Food,
	Wood,
	Coal,
	Steel,

	/// <summary> Count is how many types of resources they are. </summary>
	// Count MUST always be last on list.
	Count,
}

public struct Resource {
	public ResourceID ID;
	public float Amount;
}

public class ResourceStorage {

	readonly float[] storage = new float[(int)ResourceID.Count];

	public void Add(Resource r) {
		this[r.ID] += r.Amount;
	}

	public void Add(ResourceStorage s) {
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			this[i] += s[i];
		}
	}

	public void Sub(Resource r) {
		this[r.ID] -= r.Amount;
	}

	public void Sub(ResourceStorage s) {
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			this[i] -= s[i];
		}
	}

	public bool Has(Resource r) {
		return this[r.ID] >= r.Amount;
	}

	public bool Has(ResourceStorage s) {
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			if (this[i] < s[i]) {
				return false;
			}
		}
		return true;
	}


	public float this[ResourceID id] {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get => storage[(int)id];
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set => storage[(int)id] = value;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ResourceStorage operator +(ResourceStorage l, ResourceStorage r) {
		ResourceStorage value = new ResourceStorage();
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			value[i] = l[i] + r[i];
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ResourceStorage operator -(ResourceStorage l, ResourceStorage r) {
		ResourceStorage value = new ResourceStorage();
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			value[i] = l[i] - r[i];
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ResourceStorage operator *(ResourceStorage l, ResourceStorage r) {
		ResourceStorage value = new ResourceStorage();
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			value[i] = l[i] * r[i];
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ResourceStorage operator /(ResourceStorage l, ResourceStorage r) {
		ResourceStorage value = new ResourceStorage();
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			value[i] = l[i] / r[i];
		}
		return value;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ResourceStorage operator %(ResourceStorage l, ResourceStorage r) {
		ResourceStorage value = new ResourceStorage();
		for(ResourceID i = 0, len = ResourceID.Count; i < len; i++) {
			value[i] = l[i] % r[i];
		}
		return value;
	}
}
