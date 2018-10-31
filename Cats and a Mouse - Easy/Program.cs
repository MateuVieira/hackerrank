static string catAndMouse(int x, int y, int z) {
        int dist_XZ = Math.Abs(x - z);
        int dist_YZ = Math.Abs(y - z);

        if(dist_XZ < dist_YZ)
        {
            return "Cat A";
        }
        if(dist_YZ < dist_XZ)
        {
            return "Cat B";
        }

        return "Mouse C";

    }