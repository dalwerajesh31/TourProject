package com.example.services;
import java.util.List;
import java.util.Optional;
import com.example.entity.Package_Master;


public interface Package_Services {
		public void addPackage(Package_Master PackageMaster);
	    List<Package_Master> getPackageMasters();
	    void delete(int departureId);
	    //Package_Master upPackage(Package_Master PackageMaster, int departureId);
	    Optional<Package_Master> getById(int id);
}