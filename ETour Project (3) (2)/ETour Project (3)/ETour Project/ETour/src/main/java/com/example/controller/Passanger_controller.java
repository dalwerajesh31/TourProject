package com.example.controller;

import java.util.List;
import java.util.Optional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.entity.Passanger_Master;
import com.example.services.Passanger_Services;
@RequestMapping("api/Passanger_Master")
@RestController
@CrossOrigin("*")
public class Passanger_controller {

	@Autowired
	Passanger_Services tservices;

	@PostMapping
	public void addPassanger(@RequestBody Passanger_Master t) {
		// System.out.println(t);
		tservices.addPassanger(t);
	}

	@GetMapping("api/getPassanger")
	public List<Passanger_Master> getPassanger() {
		return tservices.getPassangerMasters();
	}

	@DeleteMapping(value = "api/deletePassanger/{id}")
	public void delete(@PathVariable int id) {
		tservices.delete(id);
	}

//			@PutMapping(value = "api/Passanger_Master/{id}")
//			public void update(@RequestBody Passanger_Master pack, @PathVariable int id) {
//				tservices.update(pack, id);
//			}

	@GetMapping(value = "api/getPassangerById/{id}")
	public Optional<Passanger_Master> Get(@PathVariable int id) {
		return tservices.getById(id);
	}
}