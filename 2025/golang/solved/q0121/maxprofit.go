package q0121

func maxProfit(prices []int) int {
	minPrice := int(^uint(0) >> 1)
	maxProfit := 0

	for _, price := range prices {
		if price < minPrice {
			minPrice = price
		} else if profit := price - minPrice; profit > maxProfit {
			maxProfit = profit
		}
	}

	return maxProfit
}
