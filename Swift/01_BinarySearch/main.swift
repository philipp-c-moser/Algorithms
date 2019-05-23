//
//  main.swift
//  Swift
//
//  Created by Philipp Moser on 23.05.19.
//  Copyright © 2019 Philipp C. Moser. All rights reserved.
//

import Foundation

// Proceed the Binary Search
func binarySearch(_ list: [Int], item: Int) -> Int? {
    
    // save the current searching-part of list
    var lowest = 0
    var highest = list.count - 1
    
    
    while lowest <= highest {
        
        // Check only the element in the middle
        // of the current range
        let middle = lowest + (highest - lowest) / 2
        
    }
    
    return nil
}




print("01 Binary Search")

// Array with all searchable values
let searchList = [ 4, 2, 6, 9, 1, 7, 5, 3 ]

// Will return positiion of searched int
// If not found, return "Not Found"
print(binarySearch(searchList, item: 1) ?? "Not Found")
