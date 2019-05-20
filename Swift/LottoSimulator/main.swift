//
//  main.swift
//  Swift
//
//  Created by Philipp Moser on 20.05.19.
//  Copyright © 2019 Philipp C. Moser. All rights reserved.
//

import Foundation

print("LottoSimulator")

let guessNumbers = [1, 6, 12, 14, 25, 33]

var lotto: [Int]

// Number of getting Lotto-Numbers
var count = 0

repeat {
    var set = Set<Int>()
    
    repeat {
        // Simulate getting Lotto-Number
        set.insert(Int.random(in: 1...49))
    } while(set.count < 6)
    
    
    count += 1
    
// Loop, as long as the arrays doesn't match
} while guessNumbers != lotto
