package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.ModelAndView;

import com.example.entity.Date_Master;
import com.example.services.Date_MasterService;

import jakarta.servlet.http.HttpServletRequest;
@RequestMapping("/Date_Master")
@RestController
@CrossOrigin("*")

public class DateMasterController 
{
	@Autowired
	Date_MasterService dservices;
	@PostMapping(value="api")
	public void addProduct(@RequestBody Date_Master d) {
		dservices.addDate(d);
	}
	@GetMapping(value="api/getDate")
	public List<Date_Master> getDateMaster() {
		return dservices.getDateMasters();
	}
	@DeleteMapping(value="api/deleteTour/{id}")
	public void delete(@PathVariable int id) {
		dservices.delete(id);
	}
//	@PutMapping(value="api/Date_Master/{id}")
//	public void update(@RequestBody Date_Master date,@PathVariable int id) {
//		dservices.update(date, id);
//	}
	@GetMapping(value="api/getDateById/{id}")
	public Optional<Date_Master> Get(@PathVariable int id) {
		return dservices.getById(id);
	}
	
}











