package com.example.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Package_Master;

import jakarta.transaction.Transactional;

@Repository
@Transactional
public interface Package_Master_repo extends JpaRepository<Package_Master, Integer> {

   
}