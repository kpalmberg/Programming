package main

import "testing"

// Test struct
type TestIOs struct {
	phoneNumber string
	expected bool
}

// Test table
var testIOs = []TestIOs{
	// Passes
	{"523-222-4444", true},
	{"562-323-1691", true},
	{"772-134-7392", true},
	{"438-883-0238", true},
	{"235-4444", true},
	{"932-0281", true},
	{"773-9013", true},
	{"328-0023", true},
	{"302-3302", true},
	{"(523) 222-4444", true},
	{"(883) 235-0823", true},
	{"(692) 262-0281", true},
	{"(802) 117-3234", true},
	{"(802) 672-6021", true},
	{"3-222-523-5235", true},
	{"1-723-273-7232", true},
	{"7-232-723-2346", true},
	{"5-623-723-1232", true},
	{"1-136-387-2038", true},

	// Failures
	{"222 222 4444", false},
	{"222 5021", false},
	{"(523) 3520", false},
	{"(523)-3520", false},
	{"001-523-552-3892", false},
	{"192-566-921-0289", false},

}

// Test function to test isValidPhoneNumber function
func TestPhoneNumberChecker(t *testing.T) {
	for _, test := range testIOs {
		result := isValidPhoneNumber(test.phoneNumber)

		if result != test.expected {
			t.Fatal("Phone number checker failed!")
		}
	}
}