package com.example.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Package_Master;
import com.example.entity.Passanger_Master;

import jakarta.transaction.Transactional;

	@Repository
	@Transactional
	public interface Passanger_Master_Repo extends JpaRepository<Passanger_Master,Integer> {


}
