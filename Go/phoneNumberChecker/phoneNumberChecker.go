package main

import (
	"regexp"
)

// Determines whether an phone number input is considered valid format
func isValidPhoneNumber(phoneNumber string) bool {
	// REGEX DEFINITIONS

	// Local format: XXX-XXXX
	reLocal := regexp.MustCompile("^\\d{3}\\-{1}\\d{4}$")

	// Standard format: XXX-XXX-XXXX
	reStandard := regexp.MustCompile("^\\d{3}\\-{1}\\d{3}\\-{1}\\d{4}$")

	// Domestic format: (XXX) XXX-XXXX format
	reDomestic := regexp.MustCompile("^\\({1}\\d{3}\\){1}\\s{1}\\d{3}\\-{1}\\d{4}$")

	// International format: X-XXX-XXX-XXXX
	reInternational := regexp.MustCompile("^\\d{1}\\-{1}\\d{3}\\-{1}\\d{3}\\-{1}\\d{4}$")

	// Check if the phone number matches any of our 4 regex definitions, if it does, it's considered a valid phone number
	if reLocal.MatchString(phoneNumber) || reStandard.MatchString(phoneNumber) || reDomestic.MatchString(phoneNumber) || reInternational.MatchString(phoneNumber){
		println("SUCCESS: The phone number is valid.")
		return true
	} else {
		println("INVALID: The phone number is invalid!!")
		return false
	}
}


func main() {
	// Just a few phone numbers to check, testing files in same directory for automated unit tests
	isValidPhoneNumber("732-222-4444")
	isValidPhoneNumber("324-4444")
	isValidPhoneNumber("(623) 222-4444")
	isValidPhoneNumber("3-222-222-4444")
}
