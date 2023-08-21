package com.example.repositories;

import com.example.entity.Date_Master;

import jakarta.transaction.Transactional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
@Transactional
public interface Date_MasterRepository extends JpaRepository<Date_Master, Integer> {

   
}