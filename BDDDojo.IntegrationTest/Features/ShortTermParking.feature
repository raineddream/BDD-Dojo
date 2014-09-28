Feature: Short-Term Parking
	The parking lot calculator calculates costs for Short-Term Parking.

Scenario Outline: Calculate Short-Term Parking Cost
	When I park my car in the Short-Term Parking Lot for <Parking Duration>
	Then I will have to pay $<Parking Costs>

Examples: 
		| Parking Duration | Parking Costs |
		| 30 minutes       | 2.00          |
