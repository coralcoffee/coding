public class GHappy {
    public static void main(String[] args) {
        GHappy gHappy = new GHappy();
        String[] testCase = { "xxggxx", "xxgxx", "xxggyygxx", "g", "gg", "", "xxgggxyz", "xxgggxyg", "xxgggxygg",
                "mgm" };
        for (int i = 0; i < testCase.length; i++) {
            boolean isHappy = gHappy.gHappy(testCase[i]);
            System.out.println(testCase[i] + " -> " + (isHappy ? "true" : "false"));
        }
    }

    public boolean gHappy(String str) {
        str = str.toLowerCase().trim();
        if (str.isEmpty()) {
            return true;
        }
        int gCount = 0;
        for (int i = 0; i < str.length(); i++) {
            if (str.charAt(i) == 'g') {
                gCount++;
            } else if (gCount == 1) {
                return false;
            } else {
                gCount = 0;
            }
        }
        return gCount != 1;
    }

}
