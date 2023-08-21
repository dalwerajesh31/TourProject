package com.example.controller;

import com.example.entity.Itinerary_Master;
import com.example.services.Itinerary_Service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;
@RequestMapping("/Itinerary_Master")
@RestController
@CrossOrigin("*")
public class Itinerary_controller {

    @Autowired
    Itinerary_Service itineraryMasterService;

    @PostMapping(value = "api")
    public void addItinerary(@RequestBody Itinerary_Master itineraryMaster) {
        itineraryMasterService.addItinerary(itineraryMaster);
    }

    @GetMapping(value = "api/getItinerary")
    public List<Itinerary_Master> getItineraryMasters() {
        return itineraryMasterService.getItineraryMasters();
    }

    @DeleteMapping(value = "api/deleteItinerary/{id}")
    public void deleteItinerary(@PathVariable int id) {
        itineraryMasterService.delete(id);
    }

	/*
	 * @PutMapping(value = "api/updateItinerary/{id}") public void
	 * updateItinerary(@RequestBody Itinerary_Master itineraryMaster, @PathVariable
	 * int id) { itineraryMasterService.update(itineraryMaster, id); }
	 */

    @GetMapping(value = "api/getItineraryById/{id}")
    public Optional<Itinerary_Master> getItineraryById(@PathVariable int id) {
        return itineraryMasterService.getById(id);
    }
}