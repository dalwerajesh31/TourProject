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

import com.example.entity.Package_Master;
import com.example.services.Package_Services;
@RequestMapping("api/Package_Master")
@RestController
@CrossOrigin("*")
public class Package_controller 
{
	@Autowired
	Package_Services dservices;
	@PostMapping
	public void addProduct(@RequestBody Package_Master d) {
		dservices.addPackage(d);
	}
	@GetMapping(value="api/getPackage")
	public List<Package_Master> getPackageMaster() {
		return dservices.getPackageMasters();
	}
	@DeleteMapping(value="api/deleteTour/{id}")
	public void delete(@PathVariable int id) {
		dservices.delete(id);
	}
//	@PutMapping(value="api/Package_Master/{id}")
//	public void upPackage(@RequestBody Package_Master Package,@PathVariable int id) {
//		dservices.upPackage(Package, id);
//	}
	@GetMapping(value="api/getPackageById/{id}")
	public Optional<Package_Master> Get(@PathVariable int id) {
		return dservices.getById(id);
	}
	
}