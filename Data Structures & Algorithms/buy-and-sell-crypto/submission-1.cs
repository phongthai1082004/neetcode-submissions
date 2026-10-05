public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices == null || prices.Length == 0)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++) {
            // Nếu gặp giá thấp hơn, cập nhật lại mốc mua thấp nhất
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            }
            // Nếu không, tính thử lợi nhuận nếu bán tại ngày hôm nay
            else {
                int currentProfit = prices[i] - minPrice;
                if (currentProfit > maxProfit) {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}
