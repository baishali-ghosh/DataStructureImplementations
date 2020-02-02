//This segment tree update is only for finding range sum 
//TODO: Convert it into a generic type implementation with any associative operator support
public class  SegmentTree
{
    private int[] ST;

    void  build(int nodep, int start, int end)
    {
        //We store range of i..i at leaf level, ie, at leaf start and end pointers are equal
        if(start == end){
            ST[nodep] = input[start];
            Return;
        }
        else{
            int mid = (start + end)/2;
            build(2*nodep +1 , start, mid);
            build(2*nodep +2 , mid+1, end);
            ST[nodep] = ST[2*nodep+1] +  ST[2*nodep+2];
        }
    }

    int query(int nodep, int start, int end, int l, intr){
	    if(r<start or end <l )
		{
		       return 0;
		}
        //query range, lies completelycomplete overlap
        if(l<=start && end<=r)
        {
            return ST[nodep]
        }
        int mid = (start+end)/2;
        int p1 = query(2*np +1, start, mid, l,r);
        int p2 = query(2*np+2, mid+1, end, l,r);
	    return p1+p2;
    }

    void update(int node, int start, int end, int updateIdx, int val)
    {
        if(start == end)
        {
            // Leaf node  
            A[updateIdx] += val;
            tree[node] += val;
        }
        else
        {
            int mid = (start + end) / 2;
            if(start <= updateIdx and updateIdx <= mid)
            {
                // If idx is in the left child, recurse on the left child
                update(2*node+1, start, mid, updateIdx, val);
            }
            else
            {
                // if idx is in the right child, recurse on the right child
                update(2*node+2, mid+1, end, idx, val);
            }
            // Internal node will have the sum of both of its children
            tree[node] = tree[2*node + 1] + tree[2*node+2];
        }
    }
}



